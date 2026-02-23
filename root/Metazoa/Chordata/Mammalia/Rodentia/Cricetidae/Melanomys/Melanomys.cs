using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Melanomys;

/// <summary>
/// Abstract class for Melanomys (genus).
/// NCBI TaxId: 218792
/// </summary>
public abstract class Melanomys : Cricetidae, IMelanomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218792;

    /// <inheritdoc />
    public virtual string GenusName => "Melanomys";

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
