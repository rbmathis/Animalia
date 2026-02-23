using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Steatomys;

/// <summary>
/// Abstract class for Steatomys (genus).
/// NCBI TaxId: 81633
/// </summary>
public abstract class Steatomys : Nesomyidae, ISteatomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steatomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81633;

    /// <inheritdoc />
    public virtual string GenusName => "Steatomys";

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
