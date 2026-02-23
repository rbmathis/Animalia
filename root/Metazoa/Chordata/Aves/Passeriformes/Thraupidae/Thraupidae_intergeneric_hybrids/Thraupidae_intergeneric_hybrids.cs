using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Thraupidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Thraupidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3374932
/// </summary>
public abstract class Thraupidae_intergeneric_hybrids : Thraupidae, IThraupidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thraupidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3374932;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Thraupidae_intergeneric_hybrids";
}
