import Head from "next/head";
import { IEmployee } from "@/types/employee.types";
import type { GetStaticProps } from 'next'
import { Navbar } from "@/components/navnbar/Navbar";
import { UserIcon } from "@/components/Icons/UserIcon";
import InputText from "@/components/field/Input";
import axios from "axios";
import Link from "next/link";
import { useRouter } from "next/router";

export default function createEmployee({ data }: any) {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    const router = useRouter();

    async function onSubmit(e: any) {
        e.preventDefault();
        let obj: any = {};
        for (let field of e.currentTarget) {
            if (field.name !== "button" && field.value !== null) { obj[field.name] = field.value }
        }
        axios.post("/api/data/savedata", [obj],
            { headers: { 'Content-Type': 'application/json', 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } }
        ).then((res: any) => {
            console.log(res.data);
        })
        router.push("/aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT/employee");
    }

    return (
        <>
            <Head>
                <title>MedArbejder - create</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg , Nima" />
            </Head>
            <main >
                <Navbar className="bg-white" />
                <div className="flex flex-row justify-center">
                    <form key={data.id} onSubmit={onSubmit} name="fname">
                        <div className="flex flex-col text-center bg-slate-200 w-fit rounded-lg px-4 py-3">
                            <div className="flex flex-row">
                                <UserIcon className="w-28 h-28" backgroundColor="bg-green-500" />
                            </div>
                            <div className="text-start font-bold">
                                <div className="flex md:flex-row md:space-x-5 flex-col">
                                    <InputText id="firstname" label="Fornavn" placholder="Fornavn" minLength={2} required />
                                    <InputText id="lastname" label="Efernavn" placholder="Efternavn" minLength={1} required />
                                </div>
                                <InputText id="address" label="Gade & hus nr." placholder="Adresse" minLength={1} maxLength={34 + 4 + 6} required />
                                <InputText id="city" label="By" placholder="By" minLength={1} maxLength={34 + 4 + 6} required />
                                <InputText id="zip_code" label="PostNummer" placholder="(4 cifre)" minLength={1} maxLength={4} required />
                                <InputText id="department_number" label="Afdelingsnummer" placholder="Afdeling" minLength={4} maxLength={4} required />
                                <InputText id="department_leader" label="Nærmeste Leder" placholder="Philip Guldborg (CEO)" required />
                                <InputText id="skills" label="Komptencer" placholder="Evner" required />
                                <InputText id="phonenumber" label="Telefon Nummer" placholder="Max 3 nummere" minLength={6} maxLength={13 * 3} required />
                            </div>

                            <div className="flex flex-row justify-center space-x-3 text-gray-100">
                                <Link href={`./`}>
                                    <button name="button" className="bg-blue-700 w-fit h-fit px-4 py-1 rounded-lg shadow-g mt-4">
                                        Back
                                    </button>
                                </Link>
                                <button name="button" className="bg-green-500 w-fit px-4 py-1 mt-4 rounded-lg">Submit</button>
                            </div>
                        </div>
                    </form>
                </div>
            </main >
        </>
    )
}

export const getStaticProps: GetStaticProps<{ data: IEmployee }> = async ({ params }) => {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    const res = await fetch(`http://${process.env.LOCAL_IP}:${process.env.LOCAL_PORT}/api/data/employees`,
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } })
    const data = await res.json()
    return {
        props: {
            data
        }
    }
}