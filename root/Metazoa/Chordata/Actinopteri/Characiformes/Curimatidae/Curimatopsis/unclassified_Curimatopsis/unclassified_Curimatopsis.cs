using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimatopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimatopsis.unclassified_Curimatopsis;

/// <summary>
/// Abstract class for unclassified Curimatopsis (no rank).
/// NCBI TaxId: 2625358
/// </summary>
public abstract class unclassified_Curimatopsis : Curimatopsis, Iunclassified_Curimatopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Curimatopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Curimatopsis";
}
