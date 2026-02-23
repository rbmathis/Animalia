using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bubalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bubalus.unclassified_Bubalus;

/// <summary>
/// Abstract class for unclassified Bubalus (no rank).
/// NCBI TaxId: 2634834
/// </summary>
public abstract class unclassified_Bubalus : Bubalus, Iunclassified_Bubalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bubalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634834;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bubalus";
}
