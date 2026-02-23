using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Enteromius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Enteromius.unclassified_Enteromius;

/// <summary>
/// Abstract class for unclassified Enteromius (no rank).
/// NCBI TaxId: 2649316
/// </summary>
public abstract class unclassified_Enteromius : Enteromius, Iunclassified_Enteromius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enteromius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649316;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enteromius";
}
