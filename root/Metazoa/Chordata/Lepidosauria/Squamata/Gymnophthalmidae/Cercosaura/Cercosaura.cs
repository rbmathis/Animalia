using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Cercosaura;

/// <summary>
/// Abstract class for Cercosaura (genus).
/// NCBI TaxId: 174742
/// </summary>
public abstract class Cercosaura : Gymnophthalmidae, ICercosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174742;

    /// <inheritdoc />
    public virtual string GenusName => "Cercosaura";

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
