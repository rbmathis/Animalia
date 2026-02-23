using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euryoryzomys;

/// <summary>
/// Abstract class for Euryoryzomys (genus).
/// NCBI TaxId: 511942
/// </summary>
public abstract class Euryoryzomys : Cricetidae, IEuryoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euryoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 511942;

    /// <inheritdoc />
    public virtual string GenusName => "Euryoryzomys";

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
