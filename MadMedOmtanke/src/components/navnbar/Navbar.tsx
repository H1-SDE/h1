import Link from "next/link";
import React, { useState } from "react";
import Button from "../buttons/Button";
import clsx from "clsx";
import Image from "next/image";
import { useRouter } from 'next/router'

interface Props {
    className?: string;
    link?: string;
}


const MENU_LIST = [
    { text: "Depertments", href: "/departments" },
    { text: "Medarbejder", href: "/employee" },
];

export function Navbar(props: Props) {
    const [navActive, setNavActive] = useState<Boolean | null>(null);
    const router = useRouter()

    return (
        <header>
            <nav className={clsx("flex flex-row max-h-16", props.className)}>
                <div className="flex flex-row">
                    <Link href={"/"} className="w-16">
                        <Image src="/images/logo.png" alt="Logo" className="w-full object-center overflow-clip" height={0} width={0} />
                    </Link>
                    {MENU_LIST.map((menu) => {
                        if (router.asPath.slice(router.asPath.indexOf(menu.href)) === menu.href) {
                            return (
                                <Button key={menu.text} className="flex flex-col justify-center cursor-default" className1="bg-gray-800">
                                    <p className="md:text-base text-sm">{menu.text}</p>
                                </Button>
                            )
                        } else {
                            return (
                                <Link key={menu.text} href={router.asPath.slice(router.asPath.indexOf(menu.href)) === menu.href ? "" : menu.href} className="flex flex-col justify-center">
                                    <Button onClick={() => { setNavActive(false); }}>
                                        <p className="md:text-base text-sm">{menu.text}</p>
                                    </Button>
                                </Link>
                            )
                        }
                    })}
                </div>
                <Link href={"/login"} className="flex flex-col justify-center mr-2">
                    <Button>
                        <p className="md:text-base text-sm">Login</p>
                    </Button>
                </Link>

                <div onClick={() => setNavActive(!navActive)} />

            </nav>
        </header>
    );
}