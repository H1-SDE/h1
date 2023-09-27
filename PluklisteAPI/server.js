const { PrismaClient } = require("@prisma/client")
const express = require("express")
const settings = require("./settings")

const app = express()

app.use(express.urlencoded({ extended: true }))
app.use(express.json())

app.set("json spaces", 2)

// Prisma API docs: https://www.prisma.io/docs/reference/api-reference/prisma-client-reference
const prisma = new PrismaClient()

// MSSQL

// MySQL
// const table_names = `SELECT table_name as name FROM information_schema.tables WHERE table_schema = 'lager';`

app.get("/", require("./routes/all.js"))

app.get("/:tabel", require("./routes/tabel.js"))

app.get("/:tabel/:primaryKey", require("./routes/tabel_primaryKey.js"))

app.post("/:tabel/:method/:primaryKey", require("./routes/tabel_method_primaryKey.js"))

app.post("/:tabel/create", require("./routes/tabel_create.js"))

app.listen(3000)
