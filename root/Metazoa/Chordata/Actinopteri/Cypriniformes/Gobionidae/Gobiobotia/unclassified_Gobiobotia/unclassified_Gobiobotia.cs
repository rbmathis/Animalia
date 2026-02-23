using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobiobotia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobiobotia.unclassified_Gobiobotia;

/// <summary>
/// Abstract class for unclassified Gobiobotia (no rank).
/// NCBI TaxId: 2625022
/// </summary>
public abstract class unclassified_Gobiobotia : Gobiobotia, Iunclassified_Gobiobotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiobotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625022;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiobotia";
}
