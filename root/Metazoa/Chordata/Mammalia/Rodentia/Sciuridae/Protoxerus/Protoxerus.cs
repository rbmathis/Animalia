using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Protoxerus;

/// <summary>
/// Abstract class for Protoxerus (genus).
/// NCBI TaxId: 226691
/// </summary>
public abstract class Protoxerus : Sciuridae, IProtoxerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protoxerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226691;

    /// <inheritdoc />
    public virtual string GenusName => "Protoxerus";

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
