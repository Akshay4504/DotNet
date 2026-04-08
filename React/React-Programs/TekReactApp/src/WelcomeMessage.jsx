function WelcomeMessage(props){
     return ( <div>
        <h1>Welcome to the , {props.name}</h1>
        </div>

     )
}

export function Welcome2React(){
    return(
        <>
        <br/>
        <h4>Another Function component</h4>
        <p>Welcome to React:</p>
        </>
    )
}

export default WelcomeMessage;