You can do that using YamlDotNet. You start by creating a YamlStream, add one or more document to it, then you can add sequences, mappings and scalars to it.

Here is an example on how to do it:

var address = new YamlMappingNode(
    new YamlScalarNode("street"),
    new YamlScalarNode("123 Tornado Alley\nSuite 16") { Style = YamlDotNet.Core.ScalarStyle.Literal },
    new YamlScalarNode("city"),
    new YamlScalarNode("East Westville"),
    new YamlScalarNode("state"),
    new YamlScalarNode("KS")
) { Anchor = "main-address" };

var stream = new YamlStream(
    new YamlDocument(
        new YamlMappingNode(
            new YamlScalarNode("repeipt"),
            new YamlScalarNode("Oz-Ware Purchase Invoice"),
            new YamlScalarNode("date"),
            new YamlScalarNode("2007-08-06"),
            new YamlScalarNode("customer"),
            new YamlMappingNode(
                new YamlScalarNode("given"),
                new YamlScalarNode("Dorothy"),
                new YamlScalarNode("family"),
                new YamlScalarNode("Gale")
            ),
            new YamlScalarNode("items"),
            new YamlSequenceNode(
                new YamlMappingNode(
                    new YamlScalarNode("part_no"),
                    new YamlScalarNode("A4786"),
                    new YamlScalarNode("descrip"),
                    new YamlScalarNode("Water Bucket (Filled)"),
                    new YamlScalarNode("price"),
                    new YamlScalarNode("1.47"),
                    new YamlScalarNode("quantity"),
                    new YamlScalarNode("4")
                ),
                new YamlMappingNode(
                    new YamlScalarNode("part_no"),
                    new YamlScalarNode("E1628"),
                    new YamlScalarNode("descrip"),
                    new YamlScalarNode("High Heeled \"Ruby\" Slippers"),
                    new YamlScalarNode("price"),
                    new YamlScalarNode("100.27"),
                    new YamlScalarNode("quantity"),
                    new YamlScalarNode("1")
                )
            ),
            new YamlScalarNode("bill-to"), address,
            new YamlScalarNode("ship-to"), address,
            new YamlScalarNode("specialDelivery"),
            new YamlScalarNode("Follow the Yellow Brick\n" +
                               "Road to the Emerald City.\n" +
                               "Pay no attention to the\n" +
                               "man behind the curtain.")
            {
                Style = YamlDotNet.Core.ScalarStyle.Literal
            }
        )
    )
);