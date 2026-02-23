using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsarius.unclassified_Opsarius;

/// <summary>
/// Abstract class for unclassified Opsarius (no rank).
/// NCBI TaxId: 2628388
/// </summary>
public abstract class unclassified_Opsarius : Opsarius, Iunclassified_Opsarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opsarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628388;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opsarius";
}
