using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chionomys;

/// <summary>
/// Abstract class for Chionomys (genus).
/// NCBI TaxId: 269648
/// </summary>
public abstract class Chionomys : Cricetidae, IChionomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chionomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269648;

    /// <inheritdoc />
    public virtual string GenusName => "Chionomys";

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
