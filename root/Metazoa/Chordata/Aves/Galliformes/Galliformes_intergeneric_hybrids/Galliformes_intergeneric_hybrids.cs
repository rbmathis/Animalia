using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Galliformes_intergeneric_hybrids;

/// <summary>
/// Abstract class for Galliformes intergeneric hybrids (unknown).
/// NCBI TaxId: 3004246
/// </summary>
public abstract class Galliformes_intergeneric_hybrids : Galliformes, IGalliformes_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galliformes intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "unknown";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3004246;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Galliformes_intergeneric_hybrids";
}
