using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mantophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mantophryne.unclassified_Mantophryne;

/// <summary>
/// Abstract class for unclassified Mantophryne (no rank).
/// NCBI TaxId: 2640759
/// </summary>
public abstract class unclassified_Mantophryne : Mantophryne, Iunclassified_Mantophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mantophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640759;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mantophryne";
}
