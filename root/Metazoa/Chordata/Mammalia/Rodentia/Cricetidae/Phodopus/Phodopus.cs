using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phodopus;

/// <summary>
/// Abstract class for Phodopus (genus).
/// NCBI TaxId: 10043
/// </summary>
public abstract class Phodopus : Cricetidae, IPhodopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phodopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10043;

    /// <inheritdoc />
    public virtual string GenusName => "Phodopus";

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
