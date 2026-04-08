import { useState } from 'react'
import Layout from './Layout'
import './App.css'
//import { BasicRouting } from './basicRouting'
import { Outlet, Route,BrowserRouter,Routes, } from 'react-router-dom'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      {/* <BasicRouting></BasicRouting>
      <Outlet></Outlet> */}
      <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout/>}>
            <Route index element={<Home/>}/>
            {/* <Route path="/blog/:id" element={<BlogsWithParams/>}/>
            <Route path="contact" element={<Contact/>}/>
            <Route path="login" element={<Login/>}/>
            <Route path="homestate" element={<HomeWithState/>}/> */}
        </Route>
      </Routes>
      </BrowserRouter>

      <Outlet></Outlet>
    </>
  )
}

export default App
