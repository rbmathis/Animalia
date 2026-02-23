using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnocypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnocypris.unclassified_Gymnocypris;

/// <summary>
/// Abstract class for unclassified Gymnocypris (no rank).
/// NCBI TaxId: 2731654
/// </summary>
public abstract class unclassified_Gymnocypris : Gymnocypris, Iunclassified_Gymnocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2731654;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnocypris";
}
