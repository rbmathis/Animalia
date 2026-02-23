using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hongshuia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hongshuia.unclassified_Hongshuia;

/// <summary>
/// Abstract class for unclassified Hongshuia (no rank).
/// NCBI TaxId: 3139865
/// </summary>
public abstract class unclassified_Hongshuia : Hongshuia, Iunclassified_Hongshuia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hongshuia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3139865;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hongshuia";
}
