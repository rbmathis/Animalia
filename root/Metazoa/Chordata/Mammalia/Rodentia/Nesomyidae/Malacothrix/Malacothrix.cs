using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Malacothrix;

/// <summary>
/// Abstract class for Malacothrix (genus).
/// NCBI TaxId: 37437
/// </summary>
public abstract class Malacothrix : Nesomyidae, IMalacothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37437;

    /// <inheritdoc />
    public virtual string GenusName => "Malacothrix";

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
