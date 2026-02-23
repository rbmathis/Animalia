using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Chaetodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Chaetodon.unclassified_Chaetodon;

/// <summary>
/// Abstract class for unclassified Chaetodon (no rank).
/// NCBI TaxId: 2649123
/// </summary>
public abstract class unclassified_Chaetodon : Chaetodon, Iunclassified_Chaetodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaetodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649123;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaetodon";
}
