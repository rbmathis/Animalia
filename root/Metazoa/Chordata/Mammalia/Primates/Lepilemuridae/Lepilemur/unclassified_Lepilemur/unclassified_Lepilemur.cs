using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Lepilemur.unclassified_Lepilemur;

/// <summary>
/// Abstract class for unclassified Lepilemur (no rank).
/// NCBI TaxId: 2645584
/// </summary>
public abstract class unclassified_Lepilemur : Lepilemur, Iunclassified_Lepilemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepilemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645584;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepilemur";
}
