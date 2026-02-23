using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Aethalops;

/// <summary>
/// Abstract class for Aethalops (genus).
/// NCBI TaxId: 77226
/// </summary>
public abstract class Aethalops : Pteropodidae, IAethalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77226;

    /// <inheritdoc />
    public virtual string GenusName => "Aethalops";

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
