using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Psammodynastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Psammodynastes.unclassified_Psammodynastes;

/// <summary>
/// Abstract class for unclassified Psammodynastes (no rank).
/// NCBI TaxId: 2638241
/// </summary>
public abstract class unclassified_Psammodynastes : Psammodynastes, Iunclassified_Psammodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psammodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psammodynastes";
}
