using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.unclassified_Bovidae;

/// <summary>
/// Abstract class for unclassified Bovidae (no rank).
/// NCBI TaxId: 2081492
/// </summary>
public abstract class unclassified_Bovidae : Bovidae, Iunclassified_Bovidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bovidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2081492;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bovidae";
}
