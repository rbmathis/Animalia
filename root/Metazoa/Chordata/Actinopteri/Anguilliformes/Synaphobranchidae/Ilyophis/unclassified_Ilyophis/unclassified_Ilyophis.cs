using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Ilyophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Ilyophis.unclassified_Ilyophis;

/// <summary>
/// Abstract class for unclassified Ilyophis (no rank).
/// NCBI TaxId: 2623939
/// </summary>
public abstract class unclassified_Ilyophis : Ilyophis, Iunclassified_Ilyophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ilyophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623939;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ilyophis";
}
