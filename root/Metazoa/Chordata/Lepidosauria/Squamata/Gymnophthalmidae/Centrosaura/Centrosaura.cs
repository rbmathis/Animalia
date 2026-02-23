using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Centrosaura;

/// <summary>
/// Abstract class for Centrosaura (genus).
/// NCBI TaxId: 3148931
/// </summary>
public abstract class Centrosaura : Gymnophthalmidae, ICentrosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148931;

    /// <inheritdoc />
    public virtual string GenusName => "Centrosaura";

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
