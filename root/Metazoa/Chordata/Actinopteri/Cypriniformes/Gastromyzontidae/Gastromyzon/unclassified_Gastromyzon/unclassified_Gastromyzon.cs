using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Gastromyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Gastromyzon.unclassified_Gastromyzon;

/// <summary>
/// Abstract class for unclassified Gastromyzon (no rank).
/// NCBI TaxId: 2648846
/// </summary>
public abstract class unclassified_Gastromyzon : Gastromyzon, Iunclassified_Gastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648846;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gastromyzon";
}
