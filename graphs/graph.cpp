#include <iostream>
#include <unordered_map>
#include <vector>
using namespace std;

class Graph {
private:
    unordered_map<string, vector<string>> adj;
    bool directed;

public:
    Graph(bool directed = false) {
        this->directed = directed;
    }

    void addNode(string node) {
        // TODO
    }

    void addEdge(string u, string v) {
        // TODO
    }

    vector<string> getNeighbors(string node) {
        // TODO
        return {};
    }
};
