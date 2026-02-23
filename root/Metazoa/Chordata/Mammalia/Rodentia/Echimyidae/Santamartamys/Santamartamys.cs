using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Santamartamys;

/// <summary>
/// Abstract class for Santamartamys (genus).
/// NCBI TaxId: 1568969
/// </summary>
public abstract class Santamartamys : Echimyidae, ISantamartamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Santamartamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1568969;

    /// <inheritdoc />
    public virtual string GenusName => "Santamartamys";

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
