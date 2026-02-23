using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Myzopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Myzopodidae.Myzopoda;

/// <summary>
/// Abstract class for Myzopoda (genus).
/// NCBI TaxId: 155037
/// </summary>
public abstract class Myzopoda : Myzopodidae, IMyzopoda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myzopoda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 155037;

    /// <inheritdoc />
    public virtual string GenusName => "Myzopoda";

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
