using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Handleyomys;

/// <summary>
/// Abstract class for Handleyomys (genus).
/// NCBI TaxId: 218784
/// </summary>
public abstract class Handleyomys : Cricetidae, IHandleyomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Handleyomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218784;

    /// <inheritdoc />
    public virtual string GenusName => "Handleyomys";

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
