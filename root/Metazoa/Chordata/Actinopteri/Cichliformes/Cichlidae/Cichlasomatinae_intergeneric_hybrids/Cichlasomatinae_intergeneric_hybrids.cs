using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cichlasomatinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Cichlasomatinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2856871
/// </summary>
public abstract class Cichlasomatinae_intergeneric_hybrids : Cichlidae, ICichlasomatinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cichlasomatinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2856871;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Cichlasomatinae_intergeneric_hybrids";
}
