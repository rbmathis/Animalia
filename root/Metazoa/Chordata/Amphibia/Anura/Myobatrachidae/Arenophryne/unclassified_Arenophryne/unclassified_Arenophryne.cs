using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Arenophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Arenophryne.unclassified_Arenophryne;

/// <summary>
/// Abstract class for unclassified Arenophryne (no rank).
/// NCBI TaxId: 2634532
/// </summary>
public abstract class unclassified_Arenophryne : Arenophryne, Iunclassified_Arenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634532;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arenophryne";
}
