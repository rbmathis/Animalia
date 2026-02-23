using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.unclassified_Lethrininae;

/// <summary>
/// Abstract class for unclassified Lethrininae (no rank).
/// NCBI TaxId: 2859044
/// </summary>
public abstract class unclassified_Lethrininae : Lethrinidae, Iunclassified_Lethrininae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lethrininae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2859044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lethrininae";
}
