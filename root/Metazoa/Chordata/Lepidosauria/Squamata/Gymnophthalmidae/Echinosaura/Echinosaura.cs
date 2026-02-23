using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Echinosaura;

/// <summary>
/// Abstract class for Echinosaura (genus).
/// NCBI TaxId: 174746
/// </summary>
public abstract class Echinosaura : Gymnophthalmidae, IEchinosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174746;

    /// <inheritdoc />
    public virtual string GenusName => "Echinosaura";

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
