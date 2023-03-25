import React from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import Home from "./Home/Home";
import Products from "./Products/Products";

function App() {
  const openMenu = () => {
    document.querySelector(".sidebar")?.classList.add("open");
  }
  const closeMenu = () => {
    document.querySelector(".sidebar")?.classList.remove("open");
  }
  return (
    <Router>
    <div className="grid-container">

    <link rel="stylesheet" href="style.css" />
    <title>Red Rattlesnake</title>
<body>
    <div>
        <header className="header">
            <div className="brand">
                <button onClick={openMenu}>&#9776;</button>
                <a href="index.html">Red Rattlesnake</a>
            </div>
            <div className="header-links">
                <Link to="/">Home</Link>
                <Link to="/catalog">Catalog</Link>
            </div>
        </header>
        <aside className="sidebar">
            <h3>Shopping Categories</h3>
            <button className="sidebar-close-button" onClick={closeMenu}>
              x
            </button>
            <ul>
                <li>
                    <a href="index.html">Pants</a>
                </li>

                <li>
                    <a href="index.html">Shirts</a>
                </li>
            </ul>
        </aside>
        <main className="main">
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/catalog" element={<Products />} />
            </Routes>
        </main>
        <footer>
            &copy; 2022 Red Rattlesnake
        </footer>
    </div>
</body>
</div>
</Router>
  );
}

export default App;
