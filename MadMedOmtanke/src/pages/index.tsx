import Head from 'next/head'
import { Navbar } from '@/components/navnbar/Navbar'
import Image from 'next/image'

export default function Home() {
  return (
    <>
      <Head>
        <title>Home</title>
        <meta name="description" content="Case2" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="author" content="Philip Guldborg, Nima" />
      </Head>
      <main >
        <div className='bg-marmor-pattern w-screen h-screen bg-center bg-no-repeat bg-[percentage:100%_100%]'>
          <Navbar className="bg-white" />
          <div className='flex flex-row justify-center h-full'>
            <div className='flex flex-col justify-center mb-36'>
              <h1 className='font-item text-center text-7xl pb-5'>En Del Af</h1>
              <Image src="/images/Coop_logo.png" width={0} height={0} className='w-fit' alt="" priority />
            </div>
          </div>
        </div>
      </main>
    </>
  )
}
