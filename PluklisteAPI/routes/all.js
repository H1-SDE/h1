const { PrismaClient } = require("@prisma/client")
const express = require("express")
const settings = require("../settings.json")
const router = express.Router()

const prisma = new PrismaClient()

const table_names = `SELECT name FROM SYSOBJECTS WHERE xtype = 'U'`

router.get("/", async (req, res) => {
  if (req.headers.authorization !== settings.auth && settings.authOn) {
    res.json(authErrorMessage).status(401).end()
  } else {
    const result = await prisma.$queryRawUnsafe(table_names)
    const data = await Promise.all(
      result.map(async (tabel) => {
        const data = await prisma[tabel.name].findMany()
        return { tabel: tabel.name, data }
      })
    )

    res.json(data)
  }
})

module.exports = router
