using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Kurixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Kurixalus.unclassified_Kurixalus;

/// <summary>
/// Abstract class for unclassified Kurixalus (no rank).
/// NCBI TaxId: 2641700
/// </summary>
public abstract class unclassified_Kurixalus : Kurixalus, Iunclassified_Kurixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kurixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641700;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kurixalus";
}
