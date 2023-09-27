import EmployeeCard from "@/components/card/EmployeeCard";
import { Navbar } from "@/components/navnbar/Navbar";
import Head from "next/head";
import { IEmployee } from "@/types/employee.types";
import type { GetServerSideProps } from 'next'


export default function employee({ data }: any) {
    return (
        <>
            <Head>
                <title>MedArbejder</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg , Nima" />
            </Head>
            <main >
                <Navbar className="bg-white" />
                {data == "" ? <h1 className={'text-center w-screen flex flex-row justify-center text-2xl font-bold'}>ALLE ER FYRET VI SES ALDRIG</h1> : ""}
                <div className="flex flex-rows justify-center">
                    <div className="grid lg:grid-cols-6 gap-4 grid-cols-1 md:grid-cols-2">
                        {data.map((data: IEmployee) => (
                            <EmployeeCard key={data.id} Title={`${data.id} ${data.firstname} ${data.lastname}`} image="" link={"employee/" + data.id.replaceAll('æ', 'ae').replaceAll('ø', 'o').replaceAll('å', 'a')} />
                        ))}
                    </div>
                </div>
            </main>
        </>
    )
}

export const getServerSideProps: GetServerSideProps<{ data: IEmployee[] }> = async () => {
    const res = await fetch(`http://${process.env.LOCAL_IP}:${process.env.LOCAL_PORT}/api/data/employees`,
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } })
    const data = await res.json()

    return {
        props: {
            data
        }
    }
}