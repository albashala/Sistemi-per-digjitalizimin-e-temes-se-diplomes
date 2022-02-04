import React from 'react';
import Navbar from '../components/ProfileSidebar/Navbar.js';


function StudentProfile() {
  return (
    <div className='studentProfile'>
      <Navbar/>
      <div style={{
        width: "600px",
        height:"500px",
        border: "3px solid #244082",
        margin: "0 auto",
        marginTop: "20px",
        padding: "20px",
        display: "flex",
        flexDirection :"column",
        justifyContent: "space-evenly",
        color: "#244082",
        
      }}>
        <h1>Te dhenat personale:</h1>
        <p>Numri personal:</p>
        <p>Emri:</p>
        <p>Mbiemri:</p>
        <p>Email: </p>
      </div>
    </div>
  );
}



export default StudentProfile;