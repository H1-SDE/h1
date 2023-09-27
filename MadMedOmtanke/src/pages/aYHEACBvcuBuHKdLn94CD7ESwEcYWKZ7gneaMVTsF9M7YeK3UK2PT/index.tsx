import Head from 'next/head'
import { Navbar } from '@/components/navnbar/Navbar'

export default function Admin() {
    return (
        <>
            <Head>
                <title>Admin</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg" />
            </Head>
            <main >
                <div className='bg-admin-meme w-screen h-screen bg-center bg-no-repeat bg-[percentage:100%_100%]'>
                    <Navbar className="bg-white" />
                </div>
            </main>
        </>
    )
}
