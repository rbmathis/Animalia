using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Simiiformes;

/// <summary>
/// Abstract class for unclassified Simiiformes (no rank).
/// NCBI TaxId: 3085341
/// </summary>
public abstract class unclassified_Simiiformes : Primates, Iunclassified_Simiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Simiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3085341;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Simiiformes";
}
