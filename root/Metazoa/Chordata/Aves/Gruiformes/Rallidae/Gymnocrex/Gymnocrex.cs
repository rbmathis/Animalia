using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gymnocrex;

/// <summary>
/// Abstract class for Gymnocrex (genus).
/// NCBI TaxId: 2861761
/// </summary>
public abstract class Gymnocrex : Rallidae, IGymnocrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocrex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861761;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocrex";

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
