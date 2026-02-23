using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Pennatomys;

/// <summary>
/// Abstract class for Pennatomys (genus).
/// NCBI TaxId: 1607770
/// </summary>
public abstract class Pennatomys : Cricetidae, IPennatomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pennatomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1607770;

    /// <inheritdoc />
    public virtual string GenusName => "Pennatomys";

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
