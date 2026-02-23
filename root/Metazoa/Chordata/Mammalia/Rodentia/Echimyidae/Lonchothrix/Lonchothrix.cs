using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Lonchothrix;

/// <summary>
/// Abstract class for Lonchothrix (genus).
/// NCBI TaxId: 176504
/// </summary>
public abstract class Lonchothrix : Echimyidae, ILonchothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176504;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchothrix";

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
