using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sepsiscus;

/// <summary>
/// Abstract class for Sepsiscus (genus).
/// NCBI TaxId: 3148954
/// </summary>
public abstract class Sepsiscus : Scincidae, ISepsiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sepsiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148954;

    /// <inheritdoc />
    public virtual string GenusName => "Sepsiscus";

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
