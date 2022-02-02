import styled from 'styled-components';
import {Link as LinkR} from 'react-router-dom';

export const SigninContainer = styled.div`
    display: flex;
    justify-content:space-between;
    height: 80px;
    z-index: 1;
    width: 100%;
    padding: 0 24px;
    max-width: 1100px;
    background: "red";

`

export const SigninBtn = styled.div`
  display: flex;
  align-items: center;
`

export const SigninBtnLink= styled(LinkR)`
  border-radius: 30px;
   font-weight:bold;
   background: #244082;
   white-space: nowrap;
   padding: 10px 22px;
   color: white;
   font-size: 16px;
   outline: none;
   border: none;
   cursor:pointer;
   transition: all 0.2s ease-in-out;
   text-decoration: none;

`
