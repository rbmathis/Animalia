using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Profundulidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Profundulidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3320155
/// </summary>
public abstract class Profundulidae_intergeneric_hybrids : Profundulidae, IProfundulidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Profundulidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3320155;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Profundulidae_intergeneric_hybrids";
}
