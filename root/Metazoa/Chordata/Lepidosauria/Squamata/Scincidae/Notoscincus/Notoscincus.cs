using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Notoscincus;

/// <summary>
/// Abstract class for Notoscincus (genus).
/// NCBI TaxId: 220787
/// </summary>
public abstract class Notoscincus : Scincidae, INotoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220787;

    /// <inheritdoc />
    public virtual string GenusName => "Notoscincus";

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
