using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Leptobotia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Leptobotia.unclassified_Leptobotia;

/// <summary>
/// Abstract class for unclassified Leptobotia (no rank).
/// NCBI TaxId: 2626737
/// </summary>
public abstract class unclassified_Leptobotia : Leptobotia, Iunclassified_Leptobotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptobotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626737;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptobotia";
}
