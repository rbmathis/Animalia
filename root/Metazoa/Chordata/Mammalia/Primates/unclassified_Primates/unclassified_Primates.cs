using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Primates;

/// <summary>
/// Abstract class for unclassified Primates (no rank).
/// NCBI TaxId: 57118
/// </summary>
public abstract class unclassified_Primates : Primates, Iunclassified_Primates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Primates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57118;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Primates";
}
