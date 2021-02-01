import React, { ReactNode } from "react";
import Link from "next/link";
import Head from "next/head";
import { createGlobalStyle } from "styled-components";
import { color, breakpoint } from "../util";

type Props = {
  children?: ReactNode;
  title?: string;
};

const GlobalStyle = createGlobalStyle`
  :root {
    --white: ${color.white};
    --primary:  ${color.primary};
    --secondary: ${color.secondary};
    --black: ${color.black};
    --gray: ${color.gray};
  }

  * {
    box-sizing: border-box;
  }

  body {
    margin: 0;
    overflow-x: hidden;
    overflow-y: scroll;
    font-family: "Montserrat", sans-serif;
    color: var(--black);
    background-color: var(--white);
    @media (min-width: ${breakpoint.laptopL}) {
      font-size: 22px;
    }
    @media (max-width: ${breakpoint.laptopL}) {
      font-size: 20px;
    }
    @media (max-width: ${breakpoint.laptop}) {
      font-size: 18px;
    }
    @media (max-width: ${breakpoint.mobileL}) {
      font-size: 16px;
    }
  }
`;

const Layout = ({ children, title = "This is the default title" }: Props) => (
  <>
    <GlobalStyle />
    <Head>
      <title>{title}</title>
      <meta charSet="utf-8" />
      <meta name="viewport" content="initial-scale=1.0, width=device-width" />
      <link rel="preconnect" href="https://fonts.gstatic.com" />
      <link
        href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap"
        rel="stylesheet"
      />
    </Head>
    <header>
      <nav>
        <Link href="/">
          <a>Home</a>
        </Link>{" "}
        |{" "}
        <Link href="/about">
          <a>About</a>
        </Link>{" "}
        |{" "}
        <Link href="/users">
          <a>Users List</a>
        </Link>{" "}
        | <a href="/api/users">Users API</a>
      </nav>
    </header>
    {children}
    <footer>
      <hr />
      <span>I'm here to stay (Footer)</span>
    </footer>
  </>
);

export default Layout;
