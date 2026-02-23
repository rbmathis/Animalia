using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Acratosaura;

/// <summary>
/// Abstract class for Acratosaura (genus).
/// NCBI TaxId: 1235865
/// </summary>
public abstract class Acratosaura : Gymnophthalmidae, IAcratosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acratosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1235865;

    /// <inheritdoc />
    public virtual string GenusName => "Acratosaura";

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
