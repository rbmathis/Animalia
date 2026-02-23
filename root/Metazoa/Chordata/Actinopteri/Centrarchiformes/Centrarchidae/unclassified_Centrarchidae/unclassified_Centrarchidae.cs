using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.unclassified_Centrarchidae;

/// <summary>
/// Abstract class for unclassified Centrarchidae (no rank).
/// NCBI TaxId: 1799157
/// </summary>
public abstract class unclassified_Centrarchidae : Centrarchidae, Iunclassified_Centrarchidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centrarchidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1799157;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centrarchidae";
}
