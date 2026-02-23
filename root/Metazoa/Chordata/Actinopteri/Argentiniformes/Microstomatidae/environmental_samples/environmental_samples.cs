using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1986566
/// </summary>
public abstract class environmental_samples : Microstomatidae, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1986566;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
