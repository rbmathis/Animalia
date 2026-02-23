using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Olallamys;

/// <summary>
/// Abstract class for Olallamys (genus).
/// NCBI TaxId: 1400527
/// </summary>
public abstract class Olallamys : Echimyidae, IOlallamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Olallamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1400527;

    /// <inheritdoc />
    public virtual string GenusName => "Olallamys";

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
