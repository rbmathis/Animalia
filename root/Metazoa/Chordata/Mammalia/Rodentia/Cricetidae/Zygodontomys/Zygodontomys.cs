using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Zygodontomys;

/// <summary>
/// Abstract class for Zygodontomys (genus).
/// NCBI TaxId: 157540
/// </summary>
public abstract class Zygodontomys : Cricetidae, IZygodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zygodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 157540;

    /// <inheritdoc />
    public virtual string GenusName => "Zygodontomys";

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
