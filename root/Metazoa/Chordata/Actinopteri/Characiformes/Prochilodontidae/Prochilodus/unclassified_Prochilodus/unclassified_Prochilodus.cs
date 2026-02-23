using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Prochilodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Prochilodus.unclassified_Prochilodus;

/// <summary>
/// Abstract class for unclassified Prochilodus (no rank).
/// NCBI TaxId: 2642481
/// </summary>
public abstract class unclassified_Prochilodus : Prochilodus, Iunclassified_Prochilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prochilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642481;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prochilodus";
}
