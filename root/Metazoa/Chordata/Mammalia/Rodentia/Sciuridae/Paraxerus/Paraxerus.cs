using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Paraxerus;

/// <summary>
/// Abstract class for Paraxerus (genus).
/// NCBI TaxId: 47972
/// </summary>
public abstract class Paraxerus : Sciuridae, IParaxerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraxerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47972;

    /// <inheritdoc />
    public virtual string GenusName => "Paraxerus";

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
