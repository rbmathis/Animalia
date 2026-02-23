using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Ozotoceros;

/// <summary>
/// Abstract class for Ozotoceros (genus).
/// NCBI TaxId: 63823
/// </summary>
public abstract class Ozotoceros : Cervidae, IOzotoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ozotoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63823;

    /// <inheritdoc />
    public virtual string GenusName => "Ozotoceros";

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
