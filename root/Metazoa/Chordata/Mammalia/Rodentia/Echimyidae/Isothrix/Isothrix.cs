using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Isothrix;

/// <summary>
/// Abstract class for Isothrix (genus).
/// NCBI TaxId: 30623
/// </summary>
public abstract class Isothrix : Echimyidae, IIsothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30623;

    /// <inheritdoc />
    public virtual string GenusName => "Isothrix";

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
