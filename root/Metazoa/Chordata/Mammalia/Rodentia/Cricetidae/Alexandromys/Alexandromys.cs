using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Alexandromys;

/// <summary>
/// Abstract class for Alexandromys (genus).
/// NCBI TaxId: 2162899
/// </summary>
public abstract class Alexandromys : Cricetidae, IAlexandromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alexandromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2162899;

    /// <inheritdoc />
    public virtual string GenusName => "Alexandromys";

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
