using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota;

/// <summary>
/// Abstract class for Bandicota (genus).
/// NCBI TaxId: 69078
/// </summary>
public abstract class Bandicota : Muridae, IBandicota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bandicota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69078;

    /// <inheritdoc />
    public virtual string GenusName => "Bandicota";

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
