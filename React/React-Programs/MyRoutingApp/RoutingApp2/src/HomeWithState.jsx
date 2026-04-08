import React from "react";
import { useNavigate, useLocation } from "react-router-dom";
 
const HomeWithState = () => {
  const navigate = useNavigate();
  const location = useLocation();
 
  console.log(location.state);
 
  return (
<>
<h1 style={{ color: "grey" }}>
        Home Sweet Home. Logged in as Hari {/* {location.state.email} */}
</h1>
 
      <button onClick={() => navigate("/about")}>
        About
</button>
 <button onClick={() => navigate("/contact")}>
        contact
</button>
 
      <button onClick={() => navigate(-1)}>
        Back
</button>
</>
  );
};
 
export default HomeWithState;