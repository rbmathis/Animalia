using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Pectenocypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Pectenocypris.unclassified_Pectenocypris;

/// <summary>
/// Abstract class for unclassified Pectenocypris (no rank).
/// NCBI TaxId: 2621255
/// </summary>
public abstract class unclassified_Pectenocypris : Pectenocypris, Iunclassified_Pectenocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pectenocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pectenocypris";
}
