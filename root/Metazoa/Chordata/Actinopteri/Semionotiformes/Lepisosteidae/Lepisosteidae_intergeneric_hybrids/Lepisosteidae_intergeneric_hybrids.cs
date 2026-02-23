using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Lepisosteidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Lepisosteidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3120765
/// </summary>
public abstract class Lepisosteidae_intergeneric_hybrids : Lepisosteidae, ILepisosteidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepisosteidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3120765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Lepisosteidae_intergeneric_hybrids";
}
