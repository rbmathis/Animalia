using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Zapteryx;

/// <summary>
/// Abstract class for Zapteryx (genus).
/// NCBI TaxId: 117882
/// </summary>
public abstract class Zapteryx : Rhinobatidae, IZapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117882;

    /// <inheritdoc />
    public virtual string GenusName => "Zapteryx";

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
