using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Phyllonastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Phyllonastes.unclassified_Phyllonastes;

/// <summary>
/// Abstract class for unclassified Phyllonastes (no rank).
/// NCBI TaxId: 3405126
/// </summary>
public abstract class unclassified_Phyllonastes : Phyllonastes, Iunclassified_Phyllonastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllonastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3405126;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllonastes";
}
