using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Megadontomys;

/// <summary>
/// Abstract class for Megadontomys (genus).
/// NCBI TaxId: 230078
/// </summary>
public abstract class Megadontomys : Cricetidae, IMegadontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megadontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230078;

    /// <inheritdoc />
    public virtual string GenusName => "Megadontomys";

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
