const csv = require("csvtojson")
const { PrismaClient } = require("@prisma/client")

const prisma = new PrismaClient()

async function dataToDB(obj: any[]) {
  return await prisma.employees.createMany({
    data: obj,
    skipDuplicates: true,
  })
}

function employeeFormatter(obj: any[]) {
  for (let i of obj) {
    i["phonenumber"] = parseInt(i["phonenumber"])
    i["zip_code"] = parseInt(i["zip_code"])
    i['department_number'] = parseInt(i['department_number'])

    i["id"] = (
      i["firstname"][0] +
      i["lastname"][0] +
      i["lastname"][1] +
      i["lastname"][2]
    ).toLowerCase()

    i["email"] = (
      i["firstname"][0] +
      i["lastname"] +
      "@madmedOmtanke.dk"
    ).toLowerCase()
  }

return obj
}

export default function handler(req: any, res: any) {
  if (req.headers.authorization !== "aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT") return res.status(401).json({ error: "Unauthorized" })
  if (req.method === "POST") {
    res.setHeader("Allow", "POST")
    var employee: any
    let result: any
    if (req.headers["content-type"] === "text/csv") {
      csv().fromString(req.body.replaceAll(";", ","))
        .then(async (jsonObj: any[]) => {
          employee = employeeFormatter(jsonObj)
          console.log("liste længde "+jsonObj.length)
          result = await dataToDB(jsonObj)
        })
        .then(() => res.status(200).json("Data sat ind: " + result.count))
    } else if (req.headers["content-type"] === "application/json")  {
      // If not csv
      employee = employeeFormatter(req.body)
      dataToDB(req.body).then(r => res.status(200).json("Data sat ind: " + r.count))
    }
  } else {
    res.end()
  }
}
