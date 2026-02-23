using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Golunda;

/// <summary>
/// Abstract class for Golunda (genus).
/// NCBI TaxId: 121584
/// </summary>
public abstract class Golunda : Muridae, IGolunda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Golunda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121584;

    /// <inheritdoc />
    public virtual string GenusName => "Golunda";

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
