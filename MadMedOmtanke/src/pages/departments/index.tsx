import Head from 'next/head'
import { Navbar } from '@/components/navnbar/Navbar'
import DepartmentCard from '@/components/card/DepartmentCard'
import { GetServerSideProps } from 'next'
import { Department } from '@/types/depertment.types'

export default function depatments({ data }: any) {
    return (
        <>
            <Head>
                <title>Depatments</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg" />
            </Head>
            <main >
                <Navbar className="bg-white" />
                <div className="container my-12 mx-auto px-4 md:px-12">
                    <div className="flex flex-wrap -mx-1 lg:-mx-4 space-y-5">
                        <div />
                        {data.map((data: Department) => (
                            <DepartmentCard key={data.address} location={data.address} Title={data.department_type} image={data.image} />
                        ))}
                    </div>
                </div>
            </main>
        </>
    )
}

export const getServerSideProps: GetServerSideProps<{ data: any }> = async () => {
    const res = await fetch(`http://${process.env.LOCAL_IP}:${process.env.LOCAL_PORT}/api/data/departments`,
        { headers: { 'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT' } })
    const data = await res.json()

    return {
        props: {
            data
        }
    }
}