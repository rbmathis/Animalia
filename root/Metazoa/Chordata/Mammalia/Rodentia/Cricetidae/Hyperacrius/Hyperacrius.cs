using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Hyperacrius;

/// <summary>
/// Abstract class for Hyperacrius (genus).
/// NCBI TaxId: 1472671
/// </summary>
public abstract class Hyperacrius : Cricetidae, IHyperacrius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperacrius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1472671;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperacrius";

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
