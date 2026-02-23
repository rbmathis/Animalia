using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudois;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudois.unclassified_Pseudois;

/// <summary>
/// Abstract class for unclassified Pseudois (no rank).
/// NCBI TaxId: 2632709
/// </summary>
public abstract class unclassified_Pseudois : Pseudois, Iunclassified_Pseudois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632709;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudois";
}
