using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.unclassified_Chiroptera;

/// <summary>
/// Abstract class for unclassified Chiroptera (no rank).
/// NCBI TaxId: 727696
/// </summary>
public abstract class unclassified_Chiroptera : Chiroptera, Iunclassified_Chiroptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiroptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiroptera";
}
