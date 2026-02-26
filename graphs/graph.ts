class Graph<T> {
    private adj: Map<T, T[]>;
    private directed: boolean;

    constructor(directed: boolean = false) {
        this.adj = new Map<T, T[]>();
        this.directed = directed;
    }

    addNode(node: T): void {
        // TODO
    }

    addEdge(u: T, v: T): void {
        // TODO
    }

    getNeighbors(node: T): T[] {
        // TODO
        return [];
    }
}
