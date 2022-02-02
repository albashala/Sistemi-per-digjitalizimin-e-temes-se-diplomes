import React from 'react';
import {SigninContainer,SigninBtn,SigninBtnLink } from "./SigninElements";

const Signin = () => {
  return (
      <div style={{

      }}>
        <SigninContainer>
        
            <SigninBtn>
                <SigninBtnLink to="/profile">Sign In</SigninBtnLink>
            </SigninBtn>
        </SigninContainer>
      </div>
  );
};

export default Signin;
