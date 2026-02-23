using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Duopalatinus;

/// <summary>
/// Abstract class for Duopalatinus (genus).
/// NCBI TaxId: 1150224
/// </summary>
public abstract class Duopalatinus : Pimelodidae, IDuopalatinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Duopalatinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150224;

    /// <inheritdoc />
    public virtual string GenusName => "Duopalatinus";

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
