import Head from 'next/head'
import axios from 'axios';
import React, { useState } from 'react';

export default function addViaCSV() {

    async function sendData(data: any) {
        let reader = new FileReader();
        reader.readAsText(data);
        reader.onload = await async function () {
            await axios.post("/api/data/savedata", reader.result,
                {
                    headers: {
                        'Content-Type': 'text/csv',
                        "Access-Control-Allow-Origin": "*",
                        'Authorization': 'aYHEACBvcuBuHKdLn94CD7ESwEcYWKZ7gneaMVTsF9M7YeK3UK2PT'
                    }
                    ,
                }
            ).then((res: any) => {
                console.log(res.data);
            }).then(() => {
                setMessage("File uploade");
            })

        }

    }


    // eslint-disable-next-line react-hooks/rules-of-hooks
    const [message, setMessage] = useState(String);
    const handleFile = (e: any) => {
        setMessage("");
        let file: [] = e.target.files;

        for (let i: number = 0; i < file.length; i++) {
            const fileType = file[i]['type'];
            const validImageTypes: string = 'text/csv';
            if (validImageTypes.includes(fileType)) {
                sendData(file[i]);
            } else {
                setMessage("Only csv files is accepted");
            }

        }
    };

    return (
        <>
            <Head>
                <title>Admin - CVS Add</title>
                <meta name="description" content="Case2" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <meta name="author" content="Philip Guldborg" />
            </Head>
            <div className='bg-admin-background h-screen'>
                <div className="flex flex-col justify-center w-full">
                    <div className='text-center'>
                        <h1 className='text-5xl'>Velkommen Leder</h1>
                        <p>Her kan du uploade alle dine CSV filer hurtigt og let til hjemme siden</p>
                    </div>
                    <form encType="multipart/form-data" method="POST">
                        <span className="flex justify-center items-center text-3xl mb-1 text-red-500">{message}</span>
                        <label htmlFor="dropzone-file" className="flex flex-col items-center justify-center w-full h-64 border-2 border-gray-300 border-dashed rounded-lg cursor-pointer bg-gray-50">
                            <div className="flex flex-col items-center justify-center pt-5 pb-6">
                                <svg aria-hidden="true" className="w-10 h-10 mb-3 text-gray-400" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M7 16a4 4 0 01-.88-7.903A5 5 0 1115.9 6L16 6a5 5 0 011 9.9M15 13l-3-3m0 0l-3 3m3-3v12"></path></svg>
                                <p className="mb-2 text-sm text-gray-500 dark:text-gray-400"><span className="font-semibold">Click to upload</span> or drag and drop</p>
                                <p className="text-xs text-gray-500 dark:text-gray-400">CSV ONLY</p>
                            </div>
                            <input id="dropzone-file" type="file" className="hidden" name="file" accept=".csv" onChange={handleFile} />
                        </label>
                    </form>
                </div >
            </div>
        </>
    )
}