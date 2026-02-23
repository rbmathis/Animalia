using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hypsugo;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hypsugo.unclassified_Hypsugo;

/// <summary>
/// Abstract class for unclassified Hypsugo (no rank).
/// NCBI TaxId: 2620613
/// </summary>
public abstract class unclassified_Hypsugo : Hypsugo, Iunclassified_Hypsugo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsugo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620613;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsugo";
}
