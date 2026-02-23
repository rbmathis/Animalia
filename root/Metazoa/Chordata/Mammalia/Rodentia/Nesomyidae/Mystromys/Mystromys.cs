using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Mystromys;

/// <summary>
/// Abstract class for Mystromys (genus).
/// NCBI TaxId: 56238
/// </summary>
public abstract class Mystromys : Nesomyidae, IMystromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56238;

    /// <inheritdoc />
    public virtual string GenusName => "Mystromys";

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
