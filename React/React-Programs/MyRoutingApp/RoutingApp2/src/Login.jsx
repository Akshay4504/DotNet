import { useState } from "react";
import { Navigate } from "react-router-dom";
 
const Login=()=>{
    const URL='https://http://localhost:5173/api/users';
    const [loginDetails,setLoginDetails]=useState({email:"",password:""});
    const [user,setUser]=useState(null);
 
    const handleChange=(e)=>{
        const{name,value}=e.target;
        setLoginDetails((loginDetails)=>({...loginDetails,[name]:value}));
    };
 
    const handleSubmit=(e)=>{
        e.preventDefault();
        setUser(loginDetails);
 
    };
    return(
<div>
<form >
<label >
                    Email:
<input type="email" name="email" value={loginDetails.email} 
                        onChange={handleChange} required />
</label>
<label>Password:
<input type="password" name="password" value={loginDetails.password} 
                        onChange={handleChange} required/>
</label>
 
                <button type="submit" onClick={handleSubmit}> Login </button>
 
                </form >
                    {user && <Navigate to="/homestate" state={user} replace={true}/>}
</div>
    );
};
 
export default Login;