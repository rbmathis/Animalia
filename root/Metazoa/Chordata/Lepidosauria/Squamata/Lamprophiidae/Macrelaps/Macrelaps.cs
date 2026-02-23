using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Macrelaps;

/// <summary>
/// Abstract class for Macrelaps (genus).
/// NCBI TaxId: 292830
/// </summary>
public abstract class Macrelaps : Lamprophiidae, IMacrelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292830;

    /// <inheritdoc />
    public virtual string GenusName => "Macrelaps";

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
