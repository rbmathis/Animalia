using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius.unclassified_Carassius;

/// <summary>
/// Abstract class for unclassified Carassius (no rank).
/// NCBI TaxId: 2624838
/// </summary>
public abstract class unclassified_Carassius : Carassius, Iunclassified_Carassius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carassius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carassius";
}
