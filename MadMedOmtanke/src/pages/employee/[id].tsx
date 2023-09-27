import Head from "next/head";
import { IEmployee } from "@/types/employee.types";
import type { GetStaticProps } from 'next'
import { Navbar } from "@/components/navnbar/Navbar";
import { UserIcon } from "@/components/Icons/UserIcon";
import { useRouter } from "next/router";
import Link from "next/link";

export default function editEmployee({ data }: any) {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    const router = useRouter()

    return (
        <>
            <Head>
                <title>MedArbejder - </title>
                <meta name="description" content="Case2" />
                <meta name="author" content="Philip Guldborg, Nima" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
            </Head>
            <main >
                <Navbar className="bg-white" />
                <div className="flex flex-row justify-center">
                    {data.map((data: IEmployee) => (
                        <div key={data.id} className="flex flex-col text-center bg-slate-200 w-fit rounded-lg px-4 py-3 pb-9">
                            <UserIcon className="w-28 h-28" backgroundColor="bg-green-500 self-center" />

                            <div className="text-start font-bold">
                                <h1 className="text-4xl pt-5 flex md:flex-row flex-col">Navn&nbsp; <p className="font-normal">{data.firstname}  {data.lastname}</p></h1>
                                <h2 className="text-3xl pt-5 flex md:flex-row flex-col">Stilling&nbsp;<p className="font-normal">{data.position}</p></h2>
                                <h3 className="text-2xl pt-5 flex md:flex-row flex-col">Nærmeste Leder&nbsp;<p className="font-normal">{data.department_leader}</p></h3>
                                <h3 className="text-2xl pt-5 flex md:flex-row flex-col">tlf.&nbsp;<p className="font-normal">{data.phonenumber}</p></h3>
                                <h3 className="text-2xl pt-5 flex md:flex-row flex-col">Mail&nbsp;<p className="font-normal">{data.email}</p></h3>
                            </div>
                            <Link href={`./`} className="bg-blue-700 w-fit h-fit px-7 py-3 text-center rounded-2xl font-bold text-xl text-gray-100 shadow-lg ml-5 mt-5 self-center">
                                Back
                            </Link>

                        </div>
                    ))}
                </div>
            </main >
        </>
    )
}

export async function getStaticPaths() {
    const res = await fetch(`http://${process.env.LOCAL_IP}:${process.env.LOCAL_PORT}/api/data/employees`,
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } });
    const users = await res.json();

    const paths = users.map(({ id }: IEmployee) => ({
        params: { id: id },
    }))
    return { paths, fallback: true };
}

export const getStaticProps: GetStaticProps<{ data: IEmployee }> = async ({ params }) => {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    const res = await fetch(`http://${process.env.LOCAL_IP}:${process.env.LOCAL_PORT}/api/data/employees?id=${params!.id}`,
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } })
    const data = await res.json()
    return {
        props: {
            data
        }
    }
}