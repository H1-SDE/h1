const { PrismaClient } = require("@prisma/client")
const express = require("express")
const settings = require("../settings.json")
const router = express.Router()

const prisma = new PrismaClient()

router.post("/:tabel/create", async (req, res) => {
    if (req.headers.authorization !== settings.auth && settings.authOn) {
      res.json(settings.authErrorMessage).status(401).end()
    } else {
      try {
        let data = await prisma[req.params.tabel].create({ data: req.body })
        res.json(data)
      } catch (error) {
        res.send(error).status(404)
      }
    }
  })

  module.exports = router