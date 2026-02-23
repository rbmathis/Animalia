using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Protomyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Protomyzon.unclassified_Protomyzon;

/// <summary>
/// Abstract class for unclassified Protomyzon (no rank).
/// NCBI TaxId: 2622479
/// </summary>
public abstract class unclassified_Protomyzon : Protomyzon, Iunclassified_Protomyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protomyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622479;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protomyzon";
}
