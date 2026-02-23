using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Epalzeorhynchos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Epalzeorhynchos.unclassified_Epalzeorhynchos;

/// <summary>
/// Abstract class for unclassified Epalzeorhynchos (no rank).
/// NCBI TaxId: 2623207
/// </summary>
public abstract class unclassified_Epalzeorhynchos : Epalzeorhynchos, Iunclassified_Epalzeorhynchos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epalzeorhynchos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623207;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epalzeorhynchos";
}
