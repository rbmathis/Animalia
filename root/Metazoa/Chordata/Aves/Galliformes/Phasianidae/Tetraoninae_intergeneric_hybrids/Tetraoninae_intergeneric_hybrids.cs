using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetraoninae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Tetraoninae intergeneric hybrids (no rank).
/// NCBI TaxId: 2766771
/// </summary>
public abstract class Tetraoninae_intergeneric_hybrids : Phasianidae, ITetraoninae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetraoninae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766771;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Tetraoninae_intergeneric_hybrids";
}
