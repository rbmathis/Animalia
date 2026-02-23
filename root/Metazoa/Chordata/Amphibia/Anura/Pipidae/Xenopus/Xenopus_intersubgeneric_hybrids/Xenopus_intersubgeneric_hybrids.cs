using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus.Xenopus_intersubgeneric_hybrids;

/// <summary>
/// Abstract class for Xenopus intersubgeneric hybrids (no rank).
/// NCBI TaxId: 2689254
/// </summary>
public abstract class Xenopus_intersubgeneric_hybrids : Xenopus, IXenopus_intersubgeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenopus intersubgeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689254;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Xenopus_intersubgeneric_hybrids";
}
