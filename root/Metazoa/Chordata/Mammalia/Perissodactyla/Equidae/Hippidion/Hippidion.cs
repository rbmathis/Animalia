using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Hippidion;

/// <summary>
/// Abstract class for Hippidion (genus).
/// NCBI TaxId: 216181
/// </summary>
public abstract class Hippidion : Equidae, IHippidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 216181;

    /// <inheritdoc />
    public virtual string GenusName => "Hippidion";

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
