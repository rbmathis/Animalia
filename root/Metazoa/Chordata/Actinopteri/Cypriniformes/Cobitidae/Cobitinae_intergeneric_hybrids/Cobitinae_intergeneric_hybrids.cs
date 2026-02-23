using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Cobitinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2866047
/// </summary>
public abstract class Cobitinae_intergeneric_hybrids : Cobitidae, ICobitinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cobitinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866047;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cobitinae_intergeneric_hybrids";
}
