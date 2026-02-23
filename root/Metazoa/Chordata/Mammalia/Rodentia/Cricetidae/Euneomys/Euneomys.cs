using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euneomys;

/// <summary>
/// Abstract class for Euneomys (genus).
/// NCBI TaxId: 241143
/// </summary>
public abstract class Euneomys : Cricetidae, IEuneomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euneomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241143;

    /// <inheritdoc />
    public virtual string GenusName => "Euneomys";

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
