using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Speoplatyrhinus;

/// <summary>
/// Abstract class for Speoplatyrhinus (genus).
/// NCBI TaxId: 940467
/// </summary>
public abstract class Speoplatyrhinus : Amblyopsidae, ISpeoplatyrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speoplatyrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 940467;

    /// <inheritdoc />
    public virtual string GenusName => "Speoplatyrhinus";

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
