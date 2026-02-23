using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydrodynastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydrodynastes.unclassified_Hydrodynastes;

/// <summary>
/// Abstract class for unclassified Hydrodynastes (no rank).
/// NCBI TaxId: 3467909
/// </summary>
public abstract class unclassified_Hydrodynastes : Hydrodynastes, Iunclassified_Hydrodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydrodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467909;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydrodynastes";
}
