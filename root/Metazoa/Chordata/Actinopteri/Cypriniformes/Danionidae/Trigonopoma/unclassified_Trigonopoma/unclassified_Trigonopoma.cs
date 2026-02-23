using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Trigonopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Trigonopoma.unclassified_Trigonopoma;

/// <summary>
/// Abstract class for unclassified Trigonopoma (no rank).
/// NCBI TaxId: 2713778
/// </summary>
public abstract class unclassified_Trigonopoma : Trigonopoma, Iunclassified_Trigonopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trigonopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2713778;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trigonopoma";
}
