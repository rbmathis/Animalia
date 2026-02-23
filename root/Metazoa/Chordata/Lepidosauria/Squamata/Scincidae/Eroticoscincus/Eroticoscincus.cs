using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eroticoscincus;

/// <summary>
/// Abstract class for Eroticoscincus (genus).
/// NCBI TaxId: 1175181
/// </summary>
public abstract class Eroticoscincus : Scincidae, IEroticoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eroticoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1175181;

    /// <inheritdoc />
    public virtual string GenusName => "Eroticoscincus";

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
