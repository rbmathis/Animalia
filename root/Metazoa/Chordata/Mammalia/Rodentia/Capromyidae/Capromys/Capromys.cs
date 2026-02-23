using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Capromys;

/// <summary>
/// Abstract class for Capromys (genus).
/// NCBI TaxId: 34841
/// </summary>
public abstract class Capromys : Capromyidae, ICapromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34841;

    /// <inheritdoc />
    public virtual string GenusName => "Capromys";

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
