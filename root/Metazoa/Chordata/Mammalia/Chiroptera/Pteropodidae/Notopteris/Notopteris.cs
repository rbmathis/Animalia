using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Notopteris;

/// <summary>
/// Abstract class for Notopteris (genus).
/// NCBI TaxId: 58077
/// </summary>
public abstract class Notopteris : Pteropodidae, INotopteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notopteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58077;

    /// <inheritdoc />
    public virtual string GenusName => "Notopteris";

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
