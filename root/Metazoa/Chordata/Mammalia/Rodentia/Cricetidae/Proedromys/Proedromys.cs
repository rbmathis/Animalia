using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Proedromys;

/// <summary>
/// Abstract class for Proedromys (genus).
/// NCBI TaxId: 575524
/// </summary>
public abstract class Proedromys : Cricetidae, IProedromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proedromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 575524;

    /// <inheritdoc />
    public virtual string GenusName => "Proedromys";

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
