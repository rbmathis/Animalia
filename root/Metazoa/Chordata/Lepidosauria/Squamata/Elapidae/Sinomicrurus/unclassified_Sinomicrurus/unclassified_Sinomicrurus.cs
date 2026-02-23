using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Sinomicrurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Sinomicrurus.unclassified_Sinomicrurus;

/// <summary>
/// Abstract class for unclassified Sinomicrurus (no rank).
/// NCBI TaxId: 2630501
/// </summary>
public abstract class unclassified_Sinomicrurus : Sinomicrurus, Iunclassified_Sinomicrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinomicrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630501;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinomicrurus";
}
