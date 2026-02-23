using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Poropuntius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Poropuntius.unclassified_Poropuntius;

/// <summary>
/// Abstract class for unclassified Poropuntius (no rank).
/// NCBI TaxId: 2644316
/// </summary>
public abstract class unclassified_Poropuntius : Poropuntius, Iunclassified_Poropuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poropuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644316;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poropuntius";
}
