using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra.unclassified_Capra;

/// <summary>
/// Abstract class for unclassified Capra (no rank).
/// NCBI TaxId: 2619455
/// </summary>
public abstract class unclassified_Capra : Capra, Iunclassified_Capra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Capra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619455;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Capra";
}
