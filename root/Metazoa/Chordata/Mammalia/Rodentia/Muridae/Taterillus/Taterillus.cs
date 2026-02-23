using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taterillus;

/// <summary>
/// Abstract class for Taterillus (genus).
/// NCBI TaxId: 119566
/// </summary>
public abstract class Taterillus : Muridae, ITaterillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taterillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119566;

    /// <inheritdoc />
    public virtual string GenusName => "Taterillus";

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
