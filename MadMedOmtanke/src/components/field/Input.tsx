import { InputHTMLAttributes } from "react";

interface Props {
    clasName?: string;
    id: string;
    label: string;
    placholder: string;
    type?: string;
    minLength?: number;
    maxLength?: number;
    pattern?: string;
    value?: string | number;
    required?: boolean;
    disabled?: boolean;


}


function InputText(props: Props) {
    let dummy: any = false;
    if (props.required) {
        return (
            <div className={props.clasName ? props.clasName : "flex flex-col"}>
                <label htmlFor={props.id} className="text-2xl pt-5 flex flex-row">{props.label}</label>
                <input type={props.type ? props.type : "text"} id={props.id} name={props.id} className="rounded-md ring-2 p-1" placeholder={props.placholder} minLength={props.minLength} maxLength={props.maxLength} pattern={props.pattern} defaultValue={props.value} required autoComplete="off" />
            </div>
        )
    }
    if (props.disabled) {
        return (
            <div className={props.clasName ? props.clasName : "flex flex-col"}>
                <label htmlFor={props.id} className="text-2xl pt-5 flex flex-row">{props.label}</label>
                <input type="text" id={props.id} name={props.id} className="rounded-md ring-2 p-1" placeholder={props.placholder} minLength={props.minLength} maxLength={props.maxLength} pattern={props.pattern} defaultValue={props.value} disabled />
            </div>
        )
    }
    return (
        <div className={props.clasName ? props.clasName : "flex flex-col"}>
            <label htmlFor={props.id} className="text-2xl pt-5 flex flex-row">{props.label}</label>
            <input type="text" id={props.id} name={props.id} className="rounded-md ring-2 p-1" placeholder={props.placholder} minLength={props.minLength} maxLength={props.maxLength} pattern={props.pattern} defaultValue={props.value} autoComplete="off" />
        </div>
    )

}
export default InputText;