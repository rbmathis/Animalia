using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Percichthyidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Percichthyidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3373720
/// </summary>
public abstract class Percichthyidae_intergeneric_hybrids : Percichthyidae, IPercichthyidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percichthyidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3373720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Percichthyidae_intergeneric_hybrids";
}
