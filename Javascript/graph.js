class Graph
{
  constructor()
  {
    this.NumberOfNodes =0;
    this.adjacentList ={};
  }
  addVertex(node)
  {
    console.log("add vertex");
    this.adjacentList[node]=[];
    this.NumberOfNodes +=1;
  }
  addEdge(node1, node2)
  {
    this.adjacentList[node1].push(node2);//undirected graph
    this.adjacentList[node2].push(node1);
  }
  showConnections()
  {
    const allNodes = Object.keys(this.adjacentList);
    //for(let node of allNodes)
    for(var node in allNodes)
    {
      let nodeConnections = this.adjacentList[node];
      let connections = "";
      //let vertex;
     // for(vertex of nodeConnections)
     for( var vertex of nodeConnections)
      {
        connections +=vertex + " ";       
      }
      console.log(node + "-->" + connections);
    }
  }
}
const myGraph = new Graph();
myGraph.addVertex('0');
myGraph.addVertex('1');
myGraph.addVertex('2');
myGraph.addVertex('3');
myGraph.addVertex('4');
myGraph.addVertex('5');
myGraph.addVertex('6');

myGraph.addEdge('3','1');
myGraph.addEdge('3','4');
myGraph.addEdge('4','2');
myGraph.addEdge('4','5');
myGraph.addEdge('1','2');
myGraph.addEdge('1','0');
myGraph.addEdge('0','2');
myGraph.addEdge('6','5');
myGraph.showConnections();

