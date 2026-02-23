using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myopus;

/// <summary>
/// Abstract class for Myopus (genus).
/// NCBI TaxId: 71002
/// </summary>
public abstract class Myopus : Cricetidae, IMyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71002;

    /// <inheritdoc />
    public virtual string GenusName => "Myopus";

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
