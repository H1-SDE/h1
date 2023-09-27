import Image from "next/image";
import { UserIcon } from "../Icons/UserIcon";
import Link from "next/link";
import { Url } from "next/dist/shared/lib/router/router";

interface Props {
    imageOn?: boolean;
    image: string;
    children?: any;
    Title: string;
    link?: Url;
}


function EmployeeCard(props: Props) {
    return (
        <Link href={props.link ? props.link : ""}>
            <div className=" px-3 py-1 text-center ml-2 rounded-xl w-60 flex flex-row justify-center">
                <div>
                    <div className="flex flex-row justify-center rounded-full w-52 h-52">
                        <div className="flex flex-col justify-center">
                            <EmployeeHelper imageOn={props.image ? true : false} image={props.image} Title={props.Title} />
                        </div>
                    </div>
                    <h3 className="mt-2 font-almarai font-bold">{props.Title}</h3>
                </div>
            </div >
        </Link>
    )
}

function EmployeeHelper(props: Props) {
    if (props.imageOn) {
        return (
            <Image src={props.image} height={0} width={0} className="h-32 w-32 object-center object-cover overflow-clip" alt={props.Title + " Image"} />
        )

    }
    return (
        <UserIcon className="w-28 h-28" backgroundColor="bg-green-500" />
    )
}
export default EmployeeCard;