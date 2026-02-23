using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pinoyscincus;

/// <summary>
/// Abstract class for Pinoyscincus (genus).
/// NCBI TaxId: 1273153
/// </summary>
public abstract class Pinoyscincus : Scincidae, IPinoyscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinoyscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1273153;

    /// <inheritdoc />
    public virtual string GenusName => "Pinoyscincus";

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
