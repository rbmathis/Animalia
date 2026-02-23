using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eugnathogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eugnathogobius.unclassified_Eugnathogobius;

/// <summary>
/// Abstract class for unclassified Eugnathogobius (no rank).
/// NCBI TaxId: 2637013
/// </summary>
public abstract class unclassified_Eugnathogobius : Eugnathogobius, Iunclassified_Eugnathogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eugnathogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637013;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eugnathogobius";
}
