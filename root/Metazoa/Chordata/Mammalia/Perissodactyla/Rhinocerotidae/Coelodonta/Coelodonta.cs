using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Coelodonta;

/// <summary>
/// Abstract class for Coelodonta (genus).
/// NCBI TaxId: 222862
/// </summary>
public abstract class Coelodonta : Rhinocerotidae, ICoelodonta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelodonta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 222862;

    /// <inheritdoc />
    public virtual string GenusName => "Coelodonta";

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
