using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chilomys;

/// <summary>
/// Abstract class for Chilomys (genus).
/// NCBI TaxId: 89116
/// </summary>
public abstract class Chilomys : Cricetidae, IChilomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89116;

    /// <inheritdoc />
    public virtual string GenusName => "Chilomys";

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
