using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo.unclassified_Homo;

/// <summary>
/// Abstract class for unclassified Homo (no rank).
/// NCBI TaxId: 2813598
/// </summary>
public abstract class unclassified_Homo : Homo, Iunclassified_Homo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Homo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2813598;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Homo";
}
