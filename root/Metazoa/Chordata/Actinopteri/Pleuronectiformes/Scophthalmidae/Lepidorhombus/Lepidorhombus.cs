using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Lepidorhombus;

/// <summary>
/// Abstract class for Lepidorhombus (genus).
/// NCBI TaxId: 154549
/// </summary>
public abstract class Lepidorhombus : Scophthalmidae, ILepidorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154549;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidorhombus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
