import { useEffect, useState } from "react"
import { useNavigate } from "react-router-dom";

export default function GetRESTAPI() {
    const[emps, setEmps] = useState([]);
    let navigate = useNavigate();

    useEffect(()=> {
        fetch("http://localhost:9000/emps")
        .then( resp => resp.json() )
        .then( data => setEmps(data));
    },[]);

    return (
        <div>
            <h1> Emp data </h1>
            <table className="table table-bordered">
                {
                   emps.map((v)=>{
                        return (
                            <tr>
                                <td>{v.empid}</td>
                                <td>{v.ename}</td>
                                <td>{v.salary}</td>
                                <td>{v.deptno}</td>
                                <td> <a onClick={()=>{navigate('/editemp',{state: v})}}>EDIT</a></td>
                            </tr>
                        )
                   }) 
                }
            </table>
        </div>
    )

}