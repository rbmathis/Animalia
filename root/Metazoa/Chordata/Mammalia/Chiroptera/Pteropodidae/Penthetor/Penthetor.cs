using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Penthetor;

/// <summary>
/// Abstract class for Penthetor (genus).
/// NCBI TaxId: 326150
/// </summary>
public abstract class Penthetor : Pteropodidae, IPenthetor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Penthetor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326150;

    /// <inheritdoc />
    public virtual string GenusName => "Penthetor";

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
