using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis.unclassified_Ovis;

/// <summary>
/// Abstract class for unclassified Ovis (no rank).
/// NCBI TaxId: 1110705
/// </summary>
public abstract class unclassified_Ovis : Ovis, Iunclassified_Ovis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ovis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1110705;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ovis";
}
