using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hemigymnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hemigymnus.unclassified_Hemigymnus;

/// <summary>
/// Abstract class for unclassified Hemigymnus (no rank).
/// NCBI TaxId: 3045282
/// </summary>
public abstract class unclassified_Hemigymnus : Hemigymnus, Iunclassified_Hemigymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemigymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045282;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemigymnus";
}
