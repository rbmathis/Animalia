using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Voeltzkowia;

/// <summary>
/// Abstract class for Voeltzkowia (genus).
/// NCBI TaxId: 143651
/// </summary>
public abstract class Voeltzkowia : Scincidae, IVoeltzkowia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Voeltzkowia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143651;

    /// <inheritdoc />
    public virtual string GenusName => "Voeltzkowia";

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
