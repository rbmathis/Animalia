using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomberomorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomberomorus.unclassified_Scomberomorus;

/// <summary>
/// Abstract class for unclassified Scomberomorus (no rank).
/// NCBI TaxId: 2623785
/// </summary>
public abstract class unclassified_Scomberomorus : Scomberomorus, Iunclassified_Scomberomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scomberomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623785;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scomberomorus";
}
