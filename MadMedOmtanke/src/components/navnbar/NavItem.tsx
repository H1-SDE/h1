import { Url } from "next/dist/shared/lib/router/router";
import Link from "next/link";
import { UrlObject } from "url"

interface Props {
    text: String;
    href: Url | UrlObject;
    active: Boolean;
}


function NavItem(props: Props) {
    return (
        <Link href={props.href}>
            {props.text}
        </Link >
    );
};

export default NavItem;