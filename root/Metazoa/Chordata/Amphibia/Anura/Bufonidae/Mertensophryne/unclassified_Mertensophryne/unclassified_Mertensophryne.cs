using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Mertensophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Mertensophryne.unclassified_Mertensophryne;

/// <summary>
/// Abstract class for unclassified Mertensophryne (no rank).
/// NCBI TaxId: 2621767
/// </summary>
public abstract class unclassified_Mertensophryne : Mertensophryne, Iunclassified_Mertensophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mertensophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621767;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mertensophryne";
}
