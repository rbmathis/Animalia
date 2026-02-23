using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Denticetopsis;

/// <summary>
/// Abstract class for Denticetopsis (genus).
/// NCBI TaxId: 2812818
/// </summary>
public abstract class Denticetopsis : Cetopsidae, IDenticetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Denticetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2812818;

    /// <inheritdoc />
    public virtual string GenusName => "Denticetopsis";

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
