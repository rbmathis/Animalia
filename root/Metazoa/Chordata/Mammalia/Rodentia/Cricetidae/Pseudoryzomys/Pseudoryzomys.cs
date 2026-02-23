using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Pseudoryzomys;

/// <summary>
/// Abstract class for Pseudoryzomys (genus).
/// NCBI TaxId: 218833
/// </summary>
public abstract class Pseudoryzomys : Cricetidae, IPseudoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218833;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoryzomys";

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
