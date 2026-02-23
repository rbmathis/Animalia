using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Spermophilopsis;

/// <summary>
/// Abstract class for Spermophilopsis (genus).
/// NCBI TaxId: 99870
/// </summary>
public abstract class Spermophilopsis : Sciuridae, ISpermophilopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spermophilopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 99870;

    /// <inheritdoc />
    public virtual string GenusName => "Spermophilopsis";

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
