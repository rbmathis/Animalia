using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Paracaesio;

/// <summary>
/// Abstract class for Paracaesio (genus).
/// NCBI TaxId: 990996
/// </summary>
public abstract class Paracaesio : Lutjanidae, IParacaesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracaesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990996;

    /// <inheritdoc />
    public virtual string GenusName => "Paracaesio";

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
