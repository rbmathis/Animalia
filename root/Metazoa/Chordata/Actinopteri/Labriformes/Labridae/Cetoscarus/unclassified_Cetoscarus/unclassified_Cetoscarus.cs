using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cetoscarus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cetoscarus.unclassified_Cetoscarus;

/// <summary>
/// Abstract class for unclassified Cetoscarus (no rank).
/// NCBI TaxId: 3446425
/// </summary>
public abstract class unclassified_Cetoscarus : Cetoscarus, Iunclassified_Cetoscarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetoscarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetoscarus";
}
