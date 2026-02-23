using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.unclassified_Hyracoidea;

/// <summary>
/// Abstract class for unclassified Hyracoidea (no rank).
/// NCBI TaxId: 1068018
/// </summary>
public abstract class unclassified_Hyracoidea : Hyracoidea, Iunclassified_Hyracoidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyracoidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1068018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyracoidea";
}
