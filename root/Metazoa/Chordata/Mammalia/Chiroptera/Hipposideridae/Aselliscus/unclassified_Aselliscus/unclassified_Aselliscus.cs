using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Aselliscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Aselliscus.unclassified_Aselliscus;

/// <summary>
/// Abstract class for unclassified Aselliscus (no rank).
/// NCBI TaxId: 2645105
/// </summary>
public abstract class unclassified_Aselliscus : Aselliscus, Iunclassified_Aselliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aselliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645105;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aselliscus";
}
