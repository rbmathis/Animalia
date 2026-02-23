using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Percidae intergeneric hybrids (no rank).
/// NCBI TaxId: 754002
/// </summary>
public abstract class Percidae_intergeneric_hybrids : Percidae, IPercidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 754002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Percidae_intergeneric_hybrids";
}
