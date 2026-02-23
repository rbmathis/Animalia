using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophorus.unclassified_Cephalophorus;

/// <summary>
/// Abstract class for unclassified Cephalophorus (no rank).
/// NCBI TaxId: 3447478
/// </summary>
public abstract class unclassified_Cephalophorus : Cephalophorus, Iunclassified_Cephalophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephalophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3447478;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephalophorus";
}
