using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microakodontomys;

/// <summary>
/// Abstract class for Microakodontomys (genus).
/// NCBI TaxId: 548549
/// </summary>
public abstract class Microakodontomys : Cricetidae, IMicroakodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microakodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548549;

    /// <inheritdoc />
    public virtual string GenusName => "Microakodontomys";

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
