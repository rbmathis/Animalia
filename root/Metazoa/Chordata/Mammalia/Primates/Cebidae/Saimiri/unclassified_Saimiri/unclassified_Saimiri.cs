using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saimiri.unclassified_Saimiri;

/// <summary>
/// Abstract class for unclassified Saimiri (no rank).
/// NCBI TaxId: 2635411
/// </summary>
public abstract class unclassified_Saimiri : Saimiri, Iunclassified_Saimiri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saimiri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635411;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saimiri";
}
