const { PrismaClient } = require("@prisma/client")

const prisma = new PrismaClient()

export default async function handler(req: any, res: any) {
  if (req.headers.authorization !== "aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT" && req.query.table !== "customer_view") return res.status(401).json({ error: "Unauthorized" })
  if (req.method === "GET") {
    let data;
    data = await prisma[req.query.table].findMany(Object.keys(req.query)[0] !== "table" ? { where: { [Object.keys(req.query)[0]]: Object.values(req.query)[0] } } : "")
    res.status(200).json(data)
  } 
  else if (req.method === "DELETE" && req.query.table === "employees") {
    const data = await prisma[req.query.table].deleteMany(
      { where: { [Object.keys(req.query)[0]]: Object.values(req.query)[0] } }
    )
    console.log(`${Object.keys(req.query)[0]}: ${Object.values(req.query)[0]}`)
    res.json(data) 
  }
}