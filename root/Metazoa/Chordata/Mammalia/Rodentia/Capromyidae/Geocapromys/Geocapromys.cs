using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Geocapromys;

/// <summary>
/// Abstract class for Geocapromys (genus).
/// NCBI TaxId: 1543401
/// </summary>
public abstract class Geocapromys : Capromyidae, IGeocapromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geocapromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543401;

    /// <inheritdoc />
    public virtual string GenusName => "Geocapromys";

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
