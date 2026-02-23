using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Pseudechis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Pseudechis.unclassified_Pseudechis;

/// <summary>
/// Abstract class for unclassified Pseudechis (no rank).
/// NCBI TaxId: 2627489
/// </summary>
public abstract class unclassified_Pseudechis : Pseudechis, Iunclassified_Pseudechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627489;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudechis";
}
