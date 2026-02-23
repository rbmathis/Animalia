using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Cardinalidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Cardinalidae intergeneric hybrids (no rank).
/// NCBI TaxId: 2969679
/// </summary>
public abstract class Cardinalidae_intergeneric_hybrids : Cardinalidae, ICardinalidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardinalidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2969679;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cardinalidae_intergeneric_hybrids";
}
