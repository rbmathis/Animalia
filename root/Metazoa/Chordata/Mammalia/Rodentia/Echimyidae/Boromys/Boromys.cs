using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Boromys;

/// <summary>
/// Abstract class for Boromys (genus).
/// NCBI TaxId: 2779810
/// </summary>
public abstract class Boromys : Echimyidae, IBoromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2779810;

    /// <inheritdoc />
    public virtual string GenusName => "Boromys";

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
