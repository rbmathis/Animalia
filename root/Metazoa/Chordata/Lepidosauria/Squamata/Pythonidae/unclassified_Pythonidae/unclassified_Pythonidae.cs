using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.unclassified_Pythonidae;

/// <summary>
/// Abstract class for unclassified Pythonidae (no rank).
/// NCBI TaxId: 2137758
/// </summary>
public abstract class unclassified_Pythonidae : Pythonidae, Iunclassified_Pythonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pythonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2137758;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pythonidae";
}
