using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Frankixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Frankixalus.unclassified_Frankixalus;

/// <summary>
/// Abstract class for unclassified Frankixalus (no rank).
/// NCBI TaxId: 2685732
/// </summary>
public abstract class unclassified_Frankixalus : Frankixalus, Iunclassified_Frankixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Frankixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685732;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Frankixalus";
}
