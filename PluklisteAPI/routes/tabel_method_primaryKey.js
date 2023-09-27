const { PrismaClient } = require("@prisma/client")
const express = require("express")
const settings = require("../settings.json")
const router = express.Router()

const prisma = new PrismaClient()

router.post("/:tabel/:method/:primaryKey", async (req, res) => {
    if (req.headers.authorization !== settings.auth && settings.authOn) {
      res.send(settings.authErrorMessage).status(401).end()
    } else {
      try {
        let data = await prisma[req.params.tabel].findMany()
  
        let id =
          await prisma.$queryRaw`SELECT COLUMN_NAME FROM Lager.INFORMATION_SCHEMA.KEY_COLUMN_USAGE
          WHERE TABLE_NAME LIKE ${req.params.tabel} AND CONSTRAINT_NAME LIKE 'PK%'`.then(
            (id) => (id = id[0].COLUMN_NAME)
          )
  
        if (req.params.method === "delete") {
          data = await prisma[req.params.tabel][req.params.method]({
            where: {
              [id]: parseInt(req.params.primaryKey)
                ? parseInt(req.params.primaryKey)
                : req.params.primaryKey,
            },
          })
        } else if (req.params.method === "update") {
          data = await prisma[req.params.tabel][req.params.method]({
            where: {
              [id]: parseInt(req.params.primaryKey)
                ? parseInt(req.params.primaryKey)
                : req.params.primaryKey,
            },
            data: req.body,
          })
        }
  
        res.json(data)
      } catch (error) {
        res.send(error).status(404)
      }
    }
  })

  module.exports = router