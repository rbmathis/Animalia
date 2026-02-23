using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Neuryurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Neuryurus.unclassified_Neuryurus;

/// <summary>
/// Abstract class for unclassified Neuryurus (no rank).
/// NCBI TaxId: 2821561
/// </summary>
public abstract class unclassified_Neuryurus : Neuryurus, Iunclassified_Neuryurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neuryurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821561;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neuryurus";
}
