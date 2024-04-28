import { useEffect, useState } from "react"

export default function EmpDetails(){
    const[Emp, setEmps] = useState([]);

    useEffect(()=> {
        console.log('Fetching data...');
        fetch("https://localhost:7257/api/Emp/GetEmps")
        .then( resp => resp.json())
        .then( data =>{
            console.log('Data received:', data);
            setEmps(data)
        })
    },[]);

    return(
        <div>
            <h1>Emp Data </h1>
            <table className="table table-bordered">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Salary</th>
                        <th>Gender</th>
                        <th>Address</th>
                    </tr>
                </thead>
                <tbody>
                {
                        Emp.map((v)=>{
                            return(
                                <tr>
                                    <td>{v.ID}</td>
                                    <td>{v.Name}</td>
                                    <td>{v.Salary}</td>
                                    <td>{v.Gender}</td>
                                    <td>{v.Address}</td>
                                </tr>
                            )
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}