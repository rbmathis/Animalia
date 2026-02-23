using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Canidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3069387
/// </summary>
public abstract class Canidae_intergeneric_hybrids : Canidae, ICanidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Canidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3069387;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Canidae_intergeneric_hybrids";
}
