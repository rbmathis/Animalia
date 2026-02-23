using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Abrocomidae.Abrocoma;

/// <summary>
/// Abstract class for Abrocoma (genus).
/// NCBI TaxId: 108854
/// </summary>
public abstract class Abrocoma : Abrocomidae, IAbrocoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abrocoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108854;

    /// <inheritdoc />
    public virtual string GenusName => "Abrocoma";

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
