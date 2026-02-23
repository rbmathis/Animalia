using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Felinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2782170
/// </summary>
public abstract class Felinae_intergeneric_hybrids : Felidae, IFelinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Felinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2782170;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Felinae_intergeneric_hybrids";
}
