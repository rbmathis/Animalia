using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Erromyzon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Erromyzon.unclassified_Erromyzon;

/// <summary>
/// Abstract class for unclassified Erromyzon (no rank).
/// NCBI TaxId: 2623146
/// </summary>
public abstract class unclassified_Erromyzon : Erromyzon, Iunclassified_Erromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623146;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erromyzon";
}
