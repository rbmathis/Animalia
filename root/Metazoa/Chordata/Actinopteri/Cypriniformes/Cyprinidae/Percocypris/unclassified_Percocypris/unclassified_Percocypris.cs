using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Percocypris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Percocypris.unclassified_Percocypris;

/// <summary>
/// Abstract class for unclassified Percocypris (no rank).
/// NCBI TaxId: 2626501
/// </summary>
public abstract class unclassified_Percocypris : Percocypris, Iunclassified_Percocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Percocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626501;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Percocypris";
}
