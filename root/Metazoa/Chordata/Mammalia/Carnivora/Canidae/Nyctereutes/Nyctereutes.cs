using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Nyctereutes;

/// <summary>
/// Abstract class for Nyctereutes (genus).
/// NCBI TaxId: 34879
/// </summary>
public abstract class Nyctereutes : Canidae, INyctereutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctereutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34879;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctereutes";

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
