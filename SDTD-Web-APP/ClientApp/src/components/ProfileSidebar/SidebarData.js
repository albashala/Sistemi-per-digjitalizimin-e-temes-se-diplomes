import React from 'react';
import * as FaIcons from 'react-icons/fa';
import * as IoIcons from 'react-icons/io';


export const SidebarData = [
  {
    title: 'Profili im',
    path: '/studentProfile',
    icon: <FaIcons.FaUserGraduate />,
    cName: 'nav-text'
  },
  {
    title: 'Paraqit temen',
    path: '/tema',
    icon: <IoIcons.IoIosPaper />,
    cName: 'nav-text'
  },
  {
    title: 'Termini im',
    path: '/termini',
    icon: <FaIcons.FaCalendarAlt />,
    cName: 'nav-text'
  }
];