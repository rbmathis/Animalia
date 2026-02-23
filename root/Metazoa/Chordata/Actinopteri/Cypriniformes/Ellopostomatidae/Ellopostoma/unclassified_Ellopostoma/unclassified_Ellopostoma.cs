using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae.Ellopostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Ellopostomatidae.Ellopostoma.unclassified_Ellopostoma;

/// <summary>
/// Abstract class for unclassified Ellopostoma (no rank).
/// NCBI TaxId: 2620857
/// </summary>
public abstract class unclassified_Ellopostoma : Ellopostoma, Iunclassified_Ellopostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ellopostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620857;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ellopostoma";
}
