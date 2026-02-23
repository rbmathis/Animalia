using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Echymipera;

/// <summary>
/// Abstract class for Echymipera (genus).
/// NCBI TaxId: 42732
/// </summary>
public abstract class Echymipera : Peroryctidae, IEchymipera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echymipera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42732;

    /// <inheritdoc />
    public virtual string GenusName => "Echymipera";

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
