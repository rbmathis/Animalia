using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus.unclassified_Lepus;

/// <summary>
/// Abstract class for unclassified Lepus (no rank).
/// NCBI TaxId: 2609096
/// </summary>
public abstract class unclassified_Lepus : Lepus, Iunclassified_Lepus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609096;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepus";
}
