using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ctenophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ctenophorus.unclassified_Ctenophorus;

/// <summary>
/// Abstract class for unclassified Ctenophorus (no rank).
/// NCBI TaxId: 2627014
/// </summary>
public abstract class unclassified_Ctenophorus : Ctenophorus, Iunclassified_Ctenophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627014;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenophorus";
}
