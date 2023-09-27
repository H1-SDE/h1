import Head from "next/head";
import { IEmployee } from "@/types/employee.types";
import type { GetStaticProps, GetStaticPaths } from 'next'
import { Navbar } from "@/components/navnbar/Navbar";
import { UserIcon } from "@/components/Icons/UserIcon";
import InputText from "@/components/field/Input";
import { InputHTMLAttributes, useState } from "react";
import axios from "axios";
import { encode } from "querystring";
import Link from "next/link";

export default function editEmployee({ data }: any) {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    const [state, setState] = useState({
        firstname: "",
        lastname: "",
        address: "",
        city: "",
        zip_code: "",
        department_leader: "",
        skills: "",
        email: ""
    });

    async function sendData(data: any) {
        let reader = new FileReader();
        reader.readAsText(data);
        reader.onload = await async function () {
            await axios.post("/api/data/savedata", reader.result,
                {
                    headers: {
                        'Content-Type': 'application/json',
                        'Access-Control-Allow-Origin': '*',
                        'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT'
                    }
                }
            ).then((res: any) => {
                console.log(res.data);
            })
        }
    }

    return (
        <>
            <Head>
                <title>MedArbejder - edit</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg , Nima" />
            </Head>
            <main >
                <Navbar className="bg-white" />
                <div className="flex flex-row justify-center">
                    {data.map((data: IEmployee) => (
                        <form key={data.id} onSubmit={sendData} name="fname">
                            <div className="flex flex-col text-center bg-slate-200 w-fit rounded-lg px-4 py-3">
                                <div className="flex flex-row">
                                    <UserIcon className="w-28 h-28" backgroundColor="bg-green-500" />
                                </div>
                                <div className="text-start font-bold">
                                    <div className="flex flex-col md:flex-row md:space-x-5 justify-center">
                                        <InputText id="firstname" label="Fornavn" placholder="Philip" value={data.firstname} minLength={2} required />
                                        <InputText id="larstname" label="Efernavn" placholder="Guldborg" value={data.lastname} minLength={1} required />
                                    </div>
                                    <div className="flex flex-col md:flex-row md:space-x-5">
                                        <InputText id="address" label="Gade & hus nr." placholder="DrømmeAllé 10D" value={data.address} minLength={1} maxLength={34 + 4 + 6} required />
                                        <InputText id="city" label="By" placholder="Sønder Felding" value={data.city} minLength={1} maxLength={34 + 4 + 6} required />
                                        <InputText id="zip_code" label="PostNummer" placholder="7280" value={data.zip_code} minLength={1} maxLength={4} required />
                                    </div>
                                    <InputText id="department_leader" label="Nærmeste Leder" placholder="Philip Guldborg (CEO)" value={data.department_leader} required />
                                    <InputText id="skills" label="God til" placholder="Bude føres" value={data.skills} required />
                                    <InputText id="phonenumber" label="Telefon Nummer" placholder="Max 3 nummere" value={data.phonenumber} minLength={6} maxLength={13 * 3 - 2} required />
                                    <InputText id="email" label="Mail" placholder="Bude føres" value={data.email} type="email" disabled />
                                </div>
                                <div className="flex flex-row justify-center space-x-3">
                                    <Link href={`../${data.id}`}>
                                        <button className="bg-blue-700 w-fit h-fit px-4 py-1 text-center rounded-lg text-gray-100 shadow-g mt-4">
                                            Back
                                        </button>
                                    </Link>
                                    <button className="bg-green-500 w-fit px-4 py-1 mt-4 text-gray-100 rounded-lg">Submit</button>

                                </div>
                            </div>
                        </form>
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
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } }
    )
    const data = await res.json()
    return {
        props: {
            data
        }
    }
}