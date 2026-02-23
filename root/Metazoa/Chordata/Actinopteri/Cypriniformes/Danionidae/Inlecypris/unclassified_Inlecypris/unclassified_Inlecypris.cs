using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Inlecypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Inlecypris.unclassified_Inlecypris;

/// <summary>
/// Abstract class for unclassified Inlecypris (no rank).
/// NCBI TaxId: 2866155
/// </summary>
public abstract class unclassified_Inlecypris : Inlecypris, Iunclassified_Inlecypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Inlecypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866155;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Inlecypris";
}
