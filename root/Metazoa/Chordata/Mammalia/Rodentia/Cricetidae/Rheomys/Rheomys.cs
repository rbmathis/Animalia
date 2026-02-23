using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rheomys;

/// <summary>
/// Abstract class for Rheomys (genus).
/// NCBI TaxId: 218835
/// </summary>
public abstract class Rheomys : Cricetidae, IRheomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218835;

    /// <inheritdoc />
    public virtual string GenusName => "Rheomys";

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
