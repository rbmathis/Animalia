using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Apocryptodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Apocryptodon.unclassified_Apocryptodon;

/// <summary>
/// Abstract class for unclassified Apocryptodon (no rank).
/// NCBI TaxId: 2630099
/// </summary>
public abstract class unclassified_Apocryptodon : Apocryptodon, Iunclassified_Apocryptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apocryptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630099;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apocryptodon";
}
