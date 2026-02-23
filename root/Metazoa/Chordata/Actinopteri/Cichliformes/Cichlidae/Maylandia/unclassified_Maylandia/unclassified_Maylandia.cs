using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Maylandia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Maylandia.unclassified_Maylandia;

/// <summary>
/// Abstract class for unclassified Maylandia (no rank).
/// NCBI TaxId: 2638503
/// </summary>
public abstract class unclassified_Maylandia : Maylandia, Iunclassified_Maylandia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Maylandia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638503;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Maylandia";
}
