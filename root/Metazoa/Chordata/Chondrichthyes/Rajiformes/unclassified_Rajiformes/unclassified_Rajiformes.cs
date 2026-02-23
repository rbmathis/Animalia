using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.unclassified_Rajiformes;

/// <summary>
/// Abstract class for unclassified Rajiformes (no rank).
/// NCBI TaxId: 725732
/// </summary>
public abstract class unclassified_Rajiformes : Rajiformes, Iunclassified_Rajiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rajiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rajiformes";
}
