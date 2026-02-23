using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Abstract class for Tapirus (genus).
/// NCBI TaxId: 9800
/// </summary>
public abstract class Tapirus : Tapiridae, ITapirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tapirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9800;

    /// <inheritdoc />
    public virtual string GenusName => "Tapirus";

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
