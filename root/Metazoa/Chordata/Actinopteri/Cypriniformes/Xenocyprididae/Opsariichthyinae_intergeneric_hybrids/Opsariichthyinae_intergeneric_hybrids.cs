using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Opsariichthyinae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Opsariichthyinae intergeneric hybrids (no rank).
/// NCBI TaxId: 3139891
/// </summary>
public abstract class Opsariichthyinae_intergeneric_hybrids : Xenocyprididae, IOpsariichthyinae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsariichthyinae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3139891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Opsariichthyinae_intergeneric_hybrids";
}
