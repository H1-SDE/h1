import Image from "next/image";
import { MapPinIcon } from "../Icons/MapPinIcon";

interface Props {
    image: HTMLImageElement;
    Title: string;
    location: string;
}


function DepartmentCard(props: Props) {
    return (
        <>
            <div className="bg-slate-300 px-3 py-1 text-center ml-2 rounded-xl w-60 min-w-[15rem] flex flex-row justify-center">
                <div>
                    <div className="flex flex-row justify-center">
                        <Image src={props.image ? props.image : "/images/Butik.png"} height={0} width={0} className="h-32 w-32 object-center object-cover overflow-clip rounded-full" alt={props.Title + " Image"} />
                    </div>
                    <h3 className="mt-2 font-almarai font-bold">{props.Title}</h3>
                    <MapPinIcon className="w-full h-10" />
                    <p>{props.location}</p>
                </div>

            </div>
        </>
    )
}
export default DepartmentCard;