using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Andinosaura;

/// <summary>
/// Abstract class for Andinosaura (genus).
/// NCBI TaxId: 2027760
/// </summary>
public abstract class Andinosaura : Gymnophthalmidae, IAndinosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andinosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2027760;

    /// <inheritdoc />
    public virtual string GenusName => "Andinosaura";

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
