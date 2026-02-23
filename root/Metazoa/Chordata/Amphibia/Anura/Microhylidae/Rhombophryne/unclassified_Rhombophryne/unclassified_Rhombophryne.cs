using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Rhombophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Rhombophryne.unclassified_Rhombophryne;

/// <summary>
/// Abstract class for unclassified Rhombophryne (no rank).
/// NCBI TaxId: 2609368
/// </summary>
public abstract class unclassified_Rhombophryne : Rhombophryne, Iunclassified_Rhombophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhombophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhombophryne";
}
