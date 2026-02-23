using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Python.unclassified_Python;

/// <summary>
/// Abstract class for unclassified Python (no rank).
/// NCBI TaxId: 3064504
/// </summary>
public abstract class unclassified_Python : Python, Iunclassified_Python
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Python";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3064504;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Python";
}
