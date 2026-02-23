using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Hemimyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Hemimyzon.unclassified_Hemimyzon;

/// <summary>
/// Abstract class for unclassified Hemimyzon (no rank).
/// NCBI TaxId: 2649270
/// </summary>
public abstract class unclassified_Hemimyzon : Hemimyzon, Iunclassified_Hemimyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemimyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649270;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemimyzon";
}
