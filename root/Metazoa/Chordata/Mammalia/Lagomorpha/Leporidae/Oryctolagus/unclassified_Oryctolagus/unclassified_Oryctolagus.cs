using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Oryctolagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Oryctolagus.unclassified_Oryctolagus;

/// <summary>
/// Abstract class for unclassified Oryctolagus (no rank).
/// NCBI TaxId: 2641529
/// </summary>
public abstract class unclassified_Oryctolagus : Oryctolagus, Iunclassified_Oryctolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oryctolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oryctolagus";
}
