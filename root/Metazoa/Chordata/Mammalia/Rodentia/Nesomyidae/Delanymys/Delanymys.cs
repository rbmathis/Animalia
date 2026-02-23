using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Delanymys;

/// <summary>
/// Abstract class for Delanymys (genus).
/// NCBI TaxId: 1392538
/// </summary>
public abstract class Delanymys : Nesomyidae, IDelanymys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delanymys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392538;

    /// <inheritdoc />
    public virtual string GenusName => "Delanymys";

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
