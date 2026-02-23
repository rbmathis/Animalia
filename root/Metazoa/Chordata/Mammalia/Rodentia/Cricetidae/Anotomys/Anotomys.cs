using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Anotomys;

/// <summary>
/// Abstract class for Anotomys (genus).
/// NCBI TaxId: 2928175
/// </summary>
public abstract class Anotomys : Cricetidae, IAnotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2928175;

    /// <inheritdoc />
    public virtual string GenusName => "Anotomys";

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
