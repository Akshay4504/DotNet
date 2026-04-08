import React,{Component} from 'react'

export const FunctionWithState=()=>{
    const [count,setCount]=useState(0);
    return(
        <div>
            <br></br>
            <h4>Function With State</h4>
            <p>Count: {count}</p>
            <button onClick={()=> setCount(count+1)}>Increment</button>
            </div>
    );
};

export default FunctionComponent