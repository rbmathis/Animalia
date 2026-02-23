using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Elasmotherium;

/// <summary>
/// Abstract class for Elasmotherium (genus).
/// NCBI TaxId: 2491730
/// </summary>
public abstract class Elasmotherium : Rhinocerotidae, IElasmotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elasmotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491730;

    /// <inheritdoc />
    public virtual string GenusName => "Elasmotherium";

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
