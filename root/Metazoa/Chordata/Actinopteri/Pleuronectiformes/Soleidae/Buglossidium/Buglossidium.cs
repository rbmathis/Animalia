using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Buglossidium;

/// <summary>
/// Abstract class for Buglossidium (genus).
/// NCBI TaxId: 90070
/// </summary>
public abstract class Buglossidium : Soleidae, IBuglossidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buglossidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90070;

    /// <inheritdoc />
    public virtual string GenusName => "Buglossidium";

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
