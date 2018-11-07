
2
down vote
I've now worked out how to do this using Yaml.Net. The YamlStream needs to be loaded with some initial content using the Load() method.

const string initialContent = "---\nversion: 1\n...";

var sr = new StringReader(initialContent);
var stream = new YamlStream();
stream.Load(sr);
You can then cast the RootNode of the YamlDocument to YamlMappingNode which has an Add method.

var rootMappingNode = (YamlMappingNode)stream.Documents[0].RootNode;   
rootMappingNode.Add("shout", "yay!");
You can then add a variety of node types before saving:

var props = new YamlMappingNode();
props.Add("prop1", "value1");
props.Add("prop2", "value2");
rootMappingNode.Add("itemWithProps", props);

var props2 = new YamlMappingNode();
props2.Add("prop1", "value1");
props2.Add("prop2", "value2");

var props3 = new YamlMappingNode();
props3.Add("prop1", "value1");
props3.Add("prop2", "value2");

var seq = new YamlSequenceNode();
seq.Add(props2);
seq.Add(props3);
rootMappingNode.Add("sequenceOfItems", seq);

var col = new YamlSequenceNode();
col.Style = SequenceStyle.Flow;
col.Add("a");
col.Add("b");
col.Add("c");

var seqMapping = new YamlMappingNode();
seqMapping.Add("collection", col);
seq.Add(seqMapping);

using (TextWriter writer = File.CreateText("C:\\temp\\test.yaml"))
    stream.Save(writer, false);
The output from this example is:

version: 1
shout: yay!
itemWithProps:
  prop1: value1
  prop2: value2
sequenceOfItems:
- prop1: value1
  prop2: value2
- prop1: value1
  prop2: value2
- collection: [a, b, c]
...