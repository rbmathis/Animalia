using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Cynopterus;

/// <summary>
/// Abstract class for Cynopterus (genus).
/// NCBI TaxId: 9399
/// </summary>
public abstract class Cynopterus : Pteropodidae, ICynopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9399;

    /// <inheritdoc />
    public virtual string GenusName => "Cynopterus";

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
