using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.unclassified_Sicydiinae;

/// <summary>
/// Abstract class for unclassified Sicydiinae (no rank).
/// NCBI TaxId: 2681252
/// </summary>
public abstract class unclassified_Sicydiinae : Gobiidae, Iunclassified_Sicydiinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicydiinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2681252;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicydiinae";
}
