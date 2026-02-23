using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Necromys;

/// <summary>
/// Abstract class for Necromys (genus).
/// NCBI TaxId: 399316
/// </summary>
public abstract class Necromys : Cricetidae, INecromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Necromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399316;

    /// <inheritdoc />
    public virtual string GenusName => "Necromys";

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
