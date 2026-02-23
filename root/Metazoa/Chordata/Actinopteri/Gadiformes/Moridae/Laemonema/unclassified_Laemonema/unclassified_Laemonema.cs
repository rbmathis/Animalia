using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Laemonema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Laemonema.unclassified_Laemonema;

/// <summary>
/// Abstract class for unclassified Laemonema (no rank).
/// NCBI TaxId: 2636046
/// </summary>
public abstract class unclassified_Laemonema : Laemonema, Iunclassified_Laemonema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laemonema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636046;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laemonema";
}
