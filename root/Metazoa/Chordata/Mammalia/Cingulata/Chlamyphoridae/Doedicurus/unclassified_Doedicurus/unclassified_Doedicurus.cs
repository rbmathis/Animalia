using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Doedicurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Doedicurus.unclassified_Doedicurus;

/// <summary>
/// Abstract class for unclassified Doedicurus (no rank).
/// NCBI TaxId: 2639227
/// </summary>
public abstract class unclassified_Doedicurus : Doedicurus, Iunclassified_Doedicurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doedicurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639227;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doedicurus";
}
