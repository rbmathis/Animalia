using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Psychosaura;

/// <summary>
/// Abstract class for Psychosaura (genus).
/// NCBI TaxId: 1332250
/// </summary>
public abstract class Psychosaura : Scincidae, IPsychosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psychosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1332250;

    /// <inheritdoc />
    public virtual string GenusName => "Psychosaura";

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
