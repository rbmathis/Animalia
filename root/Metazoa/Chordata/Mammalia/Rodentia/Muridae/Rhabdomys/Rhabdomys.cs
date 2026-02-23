using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys;

/// <summary>
/// Abstract class for Rhabdomys (genus).
/// NCBI TaxId: 121572
/// </summary>
public abstract class Rhabdomys : Muridae, IRhabdomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121572;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdomys";

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
