using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xyrichtys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xyrichtys.unclassified_Xyrichtys;

/// <summary>
/// Abstract class for unclassified Xyrichtys (no rank).
/// NCBI TaxId: 2643802
/// </summary>
public abstract class unclassified_Xyrichtys : Xyrichtys, Iunclassified_Xyrichtys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xyrichtys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xyrichtys";
}
