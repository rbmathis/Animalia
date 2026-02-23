using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nyctimene;

/// <summary>
/// Abstract class for Nyctimene (genus).
/// NCBI TaxId: 48987
/// </summary>
public abstract class Nyctimene : Pteropodidae, INyctimene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctimene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48987;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctimene";

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
