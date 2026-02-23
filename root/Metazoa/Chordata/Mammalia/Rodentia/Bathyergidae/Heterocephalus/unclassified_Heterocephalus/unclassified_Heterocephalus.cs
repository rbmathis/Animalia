using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heterocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heterocephalus.unclassified_Heterocephalus;

/// <summary>
/// Abstract class for unclassified Heterocephalus (no rank).
/// NCBI TaxId: 3383786
/// </summary>
public abstract class unclassified_Heterocephalus : Heterocephalus, Iunclassified_Heterocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3383786;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterocephalus";
}
