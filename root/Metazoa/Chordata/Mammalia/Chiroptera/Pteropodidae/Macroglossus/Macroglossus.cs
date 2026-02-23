using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Macroglossus;

/// <summary>
/// Abstract class for Macroglossus (genus).
/// NCBI TaxId: 29075
/// </summary>
public abstract class Macroglossus : Pteropodidae, IMacroglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macroglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29075;

    /// <inheritdoc />
    public virtual string GenusName => "Macroglossus";

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
