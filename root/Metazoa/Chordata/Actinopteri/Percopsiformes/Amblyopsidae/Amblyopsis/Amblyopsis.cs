using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Amblyopsidae.Amblyopsis;

/// <summary>
/// Abstract class for Amblyopsis (genus).
/// NCBI TaxId: 940463
/// </summary>
public abstract class Amblyopsis : Amblyopsidae, IAmblyopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 940463;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyopsis";

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
