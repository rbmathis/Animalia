using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Gobiomorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Gobiomorus.unclassified_Gobiomorus;

/// <summary>
/// Abstract class for unclassified Gobiomorus (no rank).
/// NCBI TaxId: 2638119
/// </summary>
public abstract class unclassified_Gobiomorus : Gobiomorus, Iunclassified_Gobiomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiomorus";
}
