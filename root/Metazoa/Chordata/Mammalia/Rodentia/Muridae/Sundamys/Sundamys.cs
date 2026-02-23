using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sundamys;

/// <summary>
/// Abstract class for Sundamys (genus).
/// NCBI TaxId: 83760
/// </summary>
public abstract class Sundamys : Muridae, ISundamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83760;

    /// <inheritdoc />
    public virtual string GenusName => "Sundamys";

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
