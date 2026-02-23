using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Makaira;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Makaira.unclassified_Makaira;

/// <summary>
/// Abstract class for unclassified Makaira (no rank).
/// NCBI TaxId: 2634956
/// </summary>
public abstract class unclassified_Makaira : Makaira, Iunclassified_Makaira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Makaira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634956;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Makaira";
}
