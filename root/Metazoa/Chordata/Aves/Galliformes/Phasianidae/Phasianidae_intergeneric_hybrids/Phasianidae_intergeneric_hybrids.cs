using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Phasianidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527878
/// </summary>
public abstract class Phasianidae_intergeneric_hybrids : Phasianidae, IPhasianidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasianidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Phasianidae_intergeneric_hybrids";
}
