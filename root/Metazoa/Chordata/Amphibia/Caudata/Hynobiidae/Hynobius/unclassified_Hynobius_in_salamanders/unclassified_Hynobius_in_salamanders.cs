using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Hynobius.unclassified_Hynobius_in_salamanders;

/// <summary>
/// Abstract class for unclassified Hynobius (in: salamanders) (no rank).
/// NCBI TaxId: 3406969
/// </summary>
public abstract class unclassified_Hynobius_in_salamanders : Hynobius, Iunclassified_Hynobius_in_salamanders
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hynobius (in: salamanders)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hynobius_in_salamanders";
}
