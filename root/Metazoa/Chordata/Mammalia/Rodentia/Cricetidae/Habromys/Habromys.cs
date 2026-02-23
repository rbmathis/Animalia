using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Habromys;

/// <summary>
/// Abstract class for Habromys (genus).
/// NCBI TaxId: 56318
/// </summary>
public abstract class Habromys : Cricetidae, IHabromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Habromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56318;

    /// <inheritdoc />
    public virtual string GenusName => "Habromys";

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
