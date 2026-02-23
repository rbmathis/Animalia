using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Plotosidae_hybrid_sp;

/// <summary>
/// Abstract class for Plotosidae hybrid sp. (no rank).
/// NCBI TaxId: 1527667
/// </summary>
public abstract class Plotosidae_hybrid_sp : Plotosidae, IPlotosidae_hybrid_sp
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plotosidae hybrid sp.";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1527667;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Plotosidae_hybrid_sp";
}
