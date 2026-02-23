using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobius.unclassified_Gobius;

/// <summary>
/// Abstract class for unclassified Gobius (no rank).
/// NCBI TaxId: 2643512
/// </summary>
public abstract class unclassified_Gobius : Gobius, Iunclassified_Gobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643512;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobius";
}
