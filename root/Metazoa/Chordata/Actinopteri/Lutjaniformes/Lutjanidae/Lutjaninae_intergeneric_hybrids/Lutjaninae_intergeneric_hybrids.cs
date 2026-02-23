using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Lutjaninae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Lutjaninae intergeneric hybrids (no rank).
/// NCBI TaxId: 2591432
/// </summary>
public abstract class Lutjaninae_intergeneric_hybrids : Lutjanidae, ILutjaninae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lutjaninae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2591432;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Lutjaninae_intergeneric_hybrids";
}
