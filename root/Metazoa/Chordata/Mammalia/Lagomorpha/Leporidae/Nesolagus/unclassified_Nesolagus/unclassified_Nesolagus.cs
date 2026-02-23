using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Nesolagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Nesolagus.unclassified_Nesolagus;

/// <summary>
/// Abstract class for unclassified Nesolagus (no rank).
/// NCBI TaxId: 2639891
/// </summary>
public abstract class unclassified_Nesolagus : Nesolagus, Iunclassified_Nesolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nesolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nesolagus";
}
