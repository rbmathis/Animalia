using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplochromini_intergeneric_hybrids;

/// <summary>
/// Abstract class for Haplochromini intergeneric hybrids (no rank).
/// NCBI TaxId: 2023730
/// </summary>
public abstract class Haplochromini_intergeneric_hybrids : Cichlidae, IHaplochromini_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplochromini intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023730;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Haplochromini_intergeneric_hybrids";
}
