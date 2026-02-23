using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Microgale;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Tenrecidae.Microgale.unclassified_Microgale;

/// <summary>
/// Abstract class for unclassified Microgale (no rank).
/// NCBI TaxId: 2628626
/// </summary>
public abstract class unclassified_Microgale : Microgale, Iunclassified_Microgale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microgale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microgale";
}
