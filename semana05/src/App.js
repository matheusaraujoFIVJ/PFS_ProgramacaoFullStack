import React, {useState, useRef} from "react";

function App() {
  const [mensagem, setMensagem] = useState('');
  const inputRef = useRef(null);
  return(
    <div>
      <label>Nome</label>
      <input
         style={{marginLeft: '10px',marginRight: '10px' }}
          type = "text"
          ref={inputRef}
        />
      <button onClick={() => setMensagem(`Olá ${inputRef.current.value}`)}>Mostrar</button>
      <p>{mensagem}</p>
    </div>
  );
}

export default App;