using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Juliomys;

/// <summary>
/// Abstract class for Juliomys (genus).
/// NCBI TaxId: 218788
/// </summary>
public abstract class Juliomys : Cricetidae, IJuliomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Juliomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218788;

    /// <inheritdoc />
    public virtual string GenusName => "Juliomys";

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
