using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pipridae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Pipridae intergeneric hybrids (no rank).
/// NCBI TaxId: 2527883
/// </summary>
public abstract class Pipridae_intergeneric_hybrids : Pipridae, IPipridae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipridae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2527883;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Pipridae_intergeneric_hybrids";
}
