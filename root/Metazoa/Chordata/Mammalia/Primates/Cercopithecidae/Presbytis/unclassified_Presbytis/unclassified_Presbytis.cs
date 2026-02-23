using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Presbytis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Presbytis.unclassified_Presbytis;

/// <summary>
/// Abstract class for unclassified Presbytis (no rank).
/// NCBI TaxId: 2651172
/// </summary>
public abstract class unclassified_Presbytis : Presbytis, Iunclassified_Presbytis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Presbytis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651172;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Presbytis";
}
