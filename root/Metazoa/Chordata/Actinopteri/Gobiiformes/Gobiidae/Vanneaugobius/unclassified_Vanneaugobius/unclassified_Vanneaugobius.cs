using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Vanneaugobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Vanneaugobius.unclassified_Vanneaugobius;

/// <summary>
/// Abstract class for unclassified Vanneaugobius (no rank).
/// NCBI TaxId: 3437369
/// </summary>
public abstract class unclassified_Vanneaugobius : Vanneaugobius, Iunclassified_Vanneaugobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vanneaugobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3437369;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vanneaugobius";
}
