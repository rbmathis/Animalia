using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufonidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Bufonidae intergeneric hybrids (no rank).
/// NCBI TaxId: 1210403
/// </summary>
public abstract class Bufonidae_intergeneric_hybrids : Bufonidae, IBufonidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bufonidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1210403;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Bufonidae_intergeneric_hybrids";
}
