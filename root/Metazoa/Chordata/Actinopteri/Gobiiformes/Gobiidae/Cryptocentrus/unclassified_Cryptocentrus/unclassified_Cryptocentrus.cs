using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentrus.unclassified_Cryptocentrus;

/// <summary>
/// Abstract class for unclassified Cryptocentrus (no rank).
/// NCBI TaxId: 2620738
/// </summary>
public abstract class unclassified_Cryptocentrus : Cryptocentrus, Iunclassified_Cryptocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620738;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptocentrus";
}
