using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus.unclassified_Sapajus;

/// <summary>
/// Abstract class for unclassified Sapajus (no rank).
/// NCBI TaxId: 2619504
/// </summary>
public abstract class unclassified_Sapajus : Sapajus, Iunclassified_Sapajus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sapajus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619504;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sapajus";
}
