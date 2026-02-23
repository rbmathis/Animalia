using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Limnodynastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Limnodynastes.unclassified_Limnodynastes;

/// <summary>
/// Abstract class for unclassified Limnodynastes (no rank).
/// NCBI TaxId: 3081057
/// </summary>
public abstract class unclassified_Limnodynastes : Limnodynastes, Iunclassified_Limnodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Limnodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3081057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Limnodynastes";
}
