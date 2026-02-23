using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chibchanomys;

/// <summary>
/// Abstract class for Chibchanomys (genus).
/// NCBI TaxId: 2928166
/// </summary>
public abstract class Chibchanomys : Cricetidae, IChibchanomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chibchanomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2928166;

    /// <inheritdoc />
    public virtual string GenusName => "Chibchanomys";

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
