using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Plerotes;

/// <summary>
/// Abstract class for Plerotes (genus).
/// NCBI TaxId: 1812309
/// </summary>
public abstract class Plerotes : Pteropodidae, IPlerotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plerotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812309;

    /// <inheritdoc />
    public virtual string GenusName => "Plerotes";

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
