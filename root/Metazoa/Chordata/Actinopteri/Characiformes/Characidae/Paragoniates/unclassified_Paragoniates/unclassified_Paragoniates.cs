using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Paragoniates;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Paragoniates.unclassified_Paragoniates;

/// <summary>
/// Abstract class for unclassified Paragoniates (no rank).
/// NCBI TaxId: 2625473
/// </summary>
public abstract class unclassified_Paragoniates : Paragoniates, Iunclassified_Paragoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paragoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625473;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paragoniates";
}
