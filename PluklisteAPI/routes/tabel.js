const { PrismaClient } = require("@prisma/client")
const express = require("express")
const settings = require("../settings.json")
const router = express.Router()

const prisma = new PrismaClient()

router.get("/:tabel", async (req, res) => {
  if (req.headers.authorization !== settings.auth && settings.authOn) {
    res.json(settings.authErrorMessage).status(401).end()
  } else {
    try {
      const data = await prisma[req.params.tabel].findMany()

      res.json(data)
    } catch (error) {
      res.json(`Kunne ikke finde tabellen '${req.params.tabel}'`).status(404)
    }
  }
})

module.exports = router
