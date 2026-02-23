using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bovinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Bovinae intergeneric hybrids (no rank).
/// NCBI TaxId: 2510329
/// </summary>
public abstract class Bovinae_intergeneric_hybrids : Bovidae, IBovinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bovinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2510329;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Bovinae_intergeneric_hybrids";
}
