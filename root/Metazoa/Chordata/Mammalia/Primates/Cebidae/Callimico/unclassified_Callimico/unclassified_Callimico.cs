using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callimico;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callimico.unclassified_Callimico;

/// <summary>
/// Abstract class for unclassified Callimico (no rank).
/// NCBI TaxId: 2634122
/// </summary>
public abstract class unclassified_Callimico : Callimico, Iunclassified_Callimico
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callimico";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634122;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callimico";
}
