using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Engraulicypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Engraulicypris.unclassified_Engraulicypris;

/// <summary>
/// Abstract class for unclassified Engraulicypris (no rank).
/// NCBI TaxId: 2626358
/// </summary>
public abstract class unclassified_Engraulicypris : Engraulicypris, Iunclassified_Engraulicypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Engraulicypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Engraulicypris";
}
