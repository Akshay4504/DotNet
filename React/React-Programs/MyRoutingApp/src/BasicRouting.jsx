import { BrowserRouter as Router,Route,Link, Routes,useNavigate,Outlet, } from "react-router-dom";

const Home = () => {
    const navigate = useNavigate();
    return (
<div> 
<h2>Home Page</h2>
<button onClick={() => navigate('/contact')}>Go to Contact</button>
</div>
);
}

const About=()=>{
    <div>
        <h2>About page:</h2>
        <nav>
            <ul>
                <li>
                    <Link to="team">Team</Link>
                </li>
                <li>
                    <Link to="company">Company</Link>
                </li>
            </ul>
        </nav>
        <Outlet/>
        
    </div>
}

const Contact=()=><h2>Contact Page</h2>;
const Team=()=><h2>Team page</h2>;
const Company=()=><h2>Company Page</h2>;

export function BasicRouting(){
    return(
        <Router>
            <nav>
                <ul>
                    <li>
                        <Link to="/">Home</Link>
                    </li>
                    <li>
                        <Link to="/about">About</Link>
                    </li>
                    <li>
                        <Link to="/contact"><Contact></Contact></Link>
                    </li>
                </ul>
            </nav>
            <Routes>
                 <Route path="/" element={<Home/> }/>
                 <Route path="/about" element={<About/> }>
                    {/* <Route path="/team" element={<Team/> }/>
                    <Route path="/company" element={<Company/> }/> */}
                </Route>
                <Route path="/contact" element={<Contact/>}/> 
            </Routes>
        </Router>
    )
}