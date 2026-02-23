using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.unclassified_Hominidae;

/// <summary>
/// Abstract class for unclassified Hominidae (no rank).
/// NCBI TaxId: 2922387
/// </summary>
public abstract class unclassified_Hominidae : Hominidae, Iunclassified_Hominidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hominidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2922387;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hominidae";
}
