using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa.unclassified_Giraffa;

/// <summary>
/// Abstract class for unclassified Giraffa (no rank).
/// NCBI TaxId: 2677366
/// </summary>
public abstract class unclassified_Giraffa : Giraffa, Iunclassified_Giraffa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Giraffa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Giraffa";
}
