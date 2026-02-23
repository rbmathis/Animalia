using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Mesalina;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Mesalina.unclassified_Mesalina;

/// <summary>
/// Abstract class for unclassified Mesalina (no rank).
/// NCBI TaxId: 2628495
/// </summary>
public abstract class unclassified_Mesalina : Mesalina, Iunclassified_Mesalina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesalina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628495;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesalina";
}
