using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Euryzygomatomys;

/// <summary>
/// Abstract class for Euryzygomatomys (genus).
/// NCBI TaxId: 43324
/// </summary>
public abstract class Euryzygomatomys : Echimyidae, IEuryzygomatomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euryzygomatomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43324;

    /// <inheritdoc />
    public virtual string GenusName => "Euryzygomatomys";

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
