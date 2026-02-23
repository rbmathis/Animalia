using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Lepidorhombus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Lepidorhombus.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1814150
/// </summary>
public abstract class environmental_samples : Lepidorhombus, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1814150;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
