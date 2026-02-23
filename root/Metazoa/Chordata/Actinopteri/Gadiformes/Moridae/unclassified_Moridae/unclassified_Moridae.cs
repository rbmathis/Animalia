using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.unclassified_Moridae;

/// <summary>
/// Abstract class for unclassified Moridae (no rank).
/// NCBI TaxId: 2580116
/// </summary>
public abstract class unclassified_Moridae : Moridae, Iunclassified_Moridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2580116;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moridae";
}
