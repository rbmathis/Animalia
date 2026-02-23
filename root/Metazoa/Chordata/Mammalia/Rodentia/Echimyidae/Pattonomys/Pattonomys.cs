using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Pattonomys;

/// <summary>
/// Abstract class for Pattonomys (genus).
/// NCBI TaxId: 1567523
/// </summary>
public abstract class Pattonomys : Echimyidae, IPattonomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pattonomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1567523;

    /// <inheritdoc />
    public virtual string GenusName => "Pattonomys";

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
