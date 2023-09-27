import Head from "next/head";
import Link from "next/link";

export default function Home() {
    return (
        <>
            <Head>
                <title>404</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg" />
            </Head>
            <main >
                <div className="matrix-body h-screen bg-black bg-no-repeat bg-cover font-matrix box-border text-[#80ff80cc]">
                    <div className="noise pointer-events-none absolute w-full h-full bg-no-repeat bg-cover" />
                    <div className="overlay pointer-events-none absolute w-full h-full" />
                    <div className="terminal uppercase p-16 h-full absolute max-w-full">
                        <h1>Error <span className="text-white">404</span></h1>
                        <p className="output">The page you are looking for might have been removed, had its name changed or is temporarily unavailable.</p>
                        <p className="output">Please try to <Link className="text-white before:content-['['] after:content-[']']" href="https://miscgang.xyz/Simon/">go back</Link> or <Link className="text-white before:content-['['] after:content-[']']" href="https://miscgang.xyz/fun/sphere/">return to the homepage</Link>.</p>
                        <p className="output">Good luck.</p>
                    </div>
                </div>
            </main>
        </>
    )
}