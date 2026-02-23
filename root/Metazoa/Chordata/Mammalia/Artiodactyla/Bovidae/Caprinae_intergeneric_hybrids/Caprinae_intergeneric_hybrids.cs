using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Caprinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Caprinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2666254
/// </summary>
public abstract class Caprinae_intergeneric_hybrids : Bovidae, ICaprinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caprinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2666254;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Caprinae_intergeneric_hybrids";
}
