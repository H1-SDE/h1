import { MouseEventHandler } from "react";
import clsx from "clsx";

interface Props {
    children?: any;
    className?: string;
    className1?: string;
    onClick?: MouseEventHandler<HTMLDivElement>;
}


function Button(props: Props) {
    return (
        <div className={clsx(props.className)}>
            <div className={clsx("bg-black text-white px-3 py-1 text-center ml-2 rounded-xl", props.className1)} onClick={props.onClick}>
                {props.children}
            </div>
        </div>
    )
}
export default Button;