using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus.unclassified_Phrynobatrachus;

/// <summary>
/// Abstract class for unclassified Phrynobatrachus (no rank).
/// NCBI TaxId: 2649798
/// </summary>
public abstract class unclassified_Phrynobatrachus : Phrynobatrachus, Iunclassified_Phrynobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649798;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynobatrachus";
}
