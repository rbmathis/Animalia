using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mallomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mallomys.unclassified_Mallomys;

/// <summary>
/// Abstract class for unclassified Mallomys (no rank).
/// NCBI TaxId: 3079506
/// </summary>
public abstract class unclassified_Mallomys : Mallomys, Iunclassified_Mallomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mallomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3079506;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mallomys";
}
