using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neusticomys;

/// <summary>
/// Abstract class for Neusticomys (genus).
/// NCBI TaxId: 548545
/// </summary>
public abstract class Neusticomys : Cricetidae, INeusticomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neusticomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548545;

    /// <inheritdoc />
    public virtual string GenusName => "Neusticomys";

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
