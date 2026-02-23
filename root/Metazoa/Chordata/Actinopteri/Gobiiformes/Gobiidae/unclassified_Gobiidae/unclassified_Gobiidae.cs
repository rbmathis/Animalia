using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.unclassified_Gobiidae;

/// <summary>
/// Abstract class for unclassified Gobiidae (no rank).
/// NCBI TaxId: 184145
/// </summary>
public abstract class unclassified_Gobiidae : Gobiidae, Iunclassified_Gobiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184145;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiidae";
}
