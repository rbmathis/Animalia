using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Leposoma;

/// <summary>
/// Abstract class for Leposoma (genus).
/// NCBI TaxId: 174750
/// </summary>
public abstract class Leposoma : Gymnophthalmidae, ILeposoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leposoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174750;

    /// <inheritdoc />
    public virtual string GenusName => "Leposoma";

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
