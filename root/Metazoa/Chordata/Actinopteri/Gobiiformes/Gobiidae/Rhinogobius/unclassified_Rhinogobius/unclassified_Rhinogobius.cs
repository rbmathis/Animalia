using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobius.unclassified_Rhinogobius;

/// <summary>
/// Abstract class for unclassified Rhinogobius (no rank).
/// NCBI TaxId: 2636376
/// </summary>
public abstract class unclassified_Rhinogobius : Rhinogobius, Iunclassified_Rhinogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636376;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinogobius";
}
