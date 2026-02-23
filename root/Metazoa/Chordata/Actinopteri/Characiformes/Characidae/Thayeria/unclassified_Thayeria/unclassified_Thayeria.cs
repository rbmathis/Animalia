using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Thayeria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Thayeria.unclassified_Thayeria;

/// <summary>
/// Abstract class for unclassified Thayeria (no rank).
/// NCBI TaxId: 3451284
/// </summary>
public abstract class unclassified_Thayeria : Thayeria, Iunclassified_Thayeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thayeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3451284;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thayeria";
}
