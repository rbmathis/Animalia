using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Saccoderma;

/// <summary>
/// Abstract class for Saccoderma (genus).
/// NCBI TaxId: 930390
/// </summary>
public abstract class Saccoderma : Characidae, ISaccoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930390;

    /// <inheritdoc />
    public virtual string GenusName => "Saccoderma";

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
