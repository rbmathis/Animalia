using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Adelophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Adelophryne.unclassified_Adelophryne;

/// <summary>
/// Abstract class for unclassified Adelophryne (no rank).
/// NCBI TaxId: 2635298
/// </summary>
public abstract class unclassified_Adelophryne : Adelophryne, Iunclassified_Adelophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Adelophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635298;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Adelophryne";
}
