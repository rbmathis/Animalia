using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.unclassified_Cypriniformes;

/// <summary>
/// Abstract class for unclassified Cypriniformes (no rank).
/// NCBI TaxId: 723961
/// </summary>
public abstract class unclassified_Cypriniformes : Cypriniformes, Iunclassified_Cypriniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cypriniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723961;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cypriniformes";
}
