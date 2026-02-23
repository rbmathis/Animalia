using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Naemorhedus.unclassified_Naemorhedus;

/// <summary>
/// Abstract class for unclassified Naemorhedus (no rank).
/// NCBI TaxId: 2637309
/// </summary>
public abstract class unclassified_Naemorhedus : Naemorhedus, Iunclassified_Naemorhedus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Naemorhedus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637309;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Naemorhedus";
}
