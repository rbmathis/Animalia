using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Campostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Campostoma.unclassified_Campostoma;

/// <summary>
/// Abstract class for unclassified Campostoma (no rank).
/// NCBI TaxId: 2677063
/// </summary>
public abstract class unclassified_Campostoma : Campostoma, Iunclassified_Campostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Campostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677063;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Campostoma";
}
