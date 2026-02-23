using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Homoroselaps;

/// <summary>
/// Abstract class for Homoroselaps (genus).
/// NCBI TaxId: 111944
/// </summary>
public abstract class Homoroselaps : Lamprophiidae, IHomoroselaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homoroselaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111944;

    /// <inheritdoc />
    public virtual string GenusName => "Homoroselaps";

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
