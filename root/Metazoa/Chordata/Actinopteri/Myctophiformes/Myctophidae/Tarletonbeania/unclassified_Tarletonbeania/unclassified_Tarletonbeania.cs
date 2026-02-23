using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Tarletonbeania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Tarletonbeania.unclassified_Tarletonbeania;

/// <summary>
/// Abstract class for unclassified Tarletonbeania (no rank).
/// NCBI TaxId: 2685256
/// </summary>
public abstract class unclassified_Tarletonbeania : Tarletonbeania, Iunclassified_Tarletonbeania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tarletonbeania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685256;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tarletonbeania";
}
