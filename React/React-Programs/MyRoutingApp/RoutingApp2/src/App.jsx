import Home from './Home';
import Layout from './Layout'
import './App.css'
import {BrowserRouter,Routes,Route,Outlet} from "react-router-dom"
import HomWithState from "./HomeWithState"
import Contact from './contact'
import Login from './Login'
 
function App() {
 
  return (
<>
<BrowserRouter>
<Routes>
<Route path='/' element={<Layout />}>
<Route index element={<Home/>}></Route>
    <Route path='homestate' element={<HomWithState />} />
    <Route path='contact' element={<Contact />} />
    <Route path='login' element={<Login />} />
</Route>
</Routes>
</BrowserRouter>
</>

  )

}
 
export default App

 