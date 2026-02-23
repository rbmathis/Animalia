using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan.unclassified_Pan;

/// <summary>
/// Abstract class for unclassified Pan (no rank).
/// NCBI TaxId: 3612877
/// </summary>
public abstract class unclassified_Pan : Pan, Iunclassified_Pan
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pan";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3612877;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pan";
}
