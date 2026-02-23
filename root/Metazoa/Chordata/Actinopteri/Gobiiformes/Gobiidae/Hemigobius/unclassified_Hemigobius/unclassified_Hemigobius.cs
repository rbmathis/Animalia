using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hemigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hemigobius.unclassified_Hemigobius;

/// <summary>
/// Abstract class for unclassified Hemigobius (no rank).
/// NCBI TaxId: 2641518
/// </summary>
public abstract class unclassified_Hemigobius : Hemigobius, Iunclassified_Hemigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemigobius";
}
