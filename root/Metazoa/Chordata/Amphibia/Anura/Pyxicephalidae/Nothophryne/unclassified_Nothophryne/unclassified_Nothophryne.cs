using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Nothophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Nothophryne.unclassified_Nothophryne;

/// <summary>
/// Abstract class for unclassified Nothophryne (no rank).
/// NCBI TaxId: 2625031
/// </summary>
public abstract class unclassified_Nothophryne : Nothophryne, Iunclassified_Nothophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nothophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nothophryne";
}
