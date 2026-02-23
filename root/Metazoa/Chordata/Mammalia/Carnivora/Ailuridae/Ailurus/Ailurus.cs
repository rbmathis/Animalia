using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ailuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ailuridae.Ailurus;

/// <summary>
/// Abstract class for Ailurus (genus).
/// NCBI TaxId: 9648
/// </summary>
public abstract class Ailurus : Ailuridae, IAilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9648;

    /// <inheritdoc />
    public virtual string GenusName => "Ailurus";

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
