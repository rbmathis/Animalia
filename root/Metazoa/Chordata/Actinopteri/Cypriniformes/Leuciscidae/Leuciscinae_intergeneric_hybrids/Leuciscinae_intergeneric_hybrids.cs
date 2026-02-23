using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leuciscinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Leuciscinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2823517
/// </summary>
public abstract class Leuciscinae_intergeneric_hybrids : Leuciscidae, ILeuciscinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leuciscinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Leuciscinae_intergeneric_hybrids";
}
