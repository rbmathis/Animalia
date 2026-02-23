using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Ancistrinae;

/// <summary>
/// Abstract class for unclassified Ancistrinae (no rank).
/// NCBI TaxId: 503185
/// </summary>
public abstract class unclassified_Ancistrinae : Loricariidae, Iunclassified_Ancistrinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ancistrinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503185;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ancistrinae";
}
