using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Osornophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Osornophryne.unclassified_Osornophryne;

/// <summary>
/// Abstract class for unclassified Osornophryne (no rank).
/// NCBI TaxId: 2649385
/// </summary>
public abstract class unclassified_Osornophryne : Osornophryne, Iunclassified_Osornophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osornophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649385;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osornophryne";
}
