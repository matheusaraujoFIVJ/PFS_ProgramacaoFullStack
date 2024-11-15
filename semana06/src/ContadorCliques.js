import React,{useContext} from "react";
import { CliqueContext } from "./App";

const ContadorCliques = () => {
    const [cliques, setCliques] = useContext(CliqueContext);
    return (
    <div>
        <button onclick={() => setCliques(cliques + 1)} >Clique aqui</button> 
        <label>{cliques}0 cliques efetuados...</label>
    </div>);
};

export default ContadorCliques;