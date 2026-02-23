using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Prasinohaema;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Prasinohaema.unclassified_Prasinohaema;

/// <summary>
/// Abstract class for unclassified Prasinohaema (no rank).
/// NCBI TaxId: 2629868
/// </summary>
public abstract class unclassified_Prasinohaema : Prasinohaema, Iunclassified_Prasinohaema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prasinohaema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629868;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prasinohaema";
}
