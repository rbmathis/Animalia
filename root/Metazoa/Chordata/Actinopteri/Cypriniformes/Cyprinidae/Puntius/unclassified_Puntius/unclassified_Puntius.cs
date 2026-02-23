using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Puntius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Puntius.unclassified_Puntius;

/// <summary>
/// Abstract class for unclassified Puntius (no rank).
/// NCBI TaxId: 2624626
/// </summary>
public abstract class unclassified_Puntius : Puntius, Iunclassified_Puntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Puntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Puntius";
}
