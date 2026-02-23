using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.unclassified_Gobiinae;

/// <summary>
/// Abstract class for unclassified Gobiinae (no rank).
/// NCBI TaxId: 1182902
/// </summary>
public abstract class unclassified_Gobiinae : Gobiidae, Iunclassified_Gobiinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182902;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiinae";
}
