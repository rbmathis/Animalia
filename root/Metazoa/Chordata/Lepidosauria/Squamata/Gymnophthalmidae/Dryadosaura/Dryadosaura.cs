using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Dryadosaura;

/// <summary>
/// Abstract class for Dryadosaura (genus).
/// NCBI TaxId: 1437463
/// </summary>
public abstract class Dryadosaura : Gymnophthalmidae, IDryadosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryadosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1437463;

    /// <inheritdoc />
    public virtual string GenusName => "Dryadosaura";

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
