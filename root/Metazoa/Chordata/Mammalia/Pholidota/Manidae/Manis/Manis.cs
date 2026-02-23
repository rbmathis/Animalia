using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Abstract class for Manis (genus).
/// NCBI TaxId: 9973
/// </summary>
public abstract class Manis : Manidae, IManis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Manis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9973;

    /// <inheritdoc />
    public virtual string GenusName => "Manis";

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
