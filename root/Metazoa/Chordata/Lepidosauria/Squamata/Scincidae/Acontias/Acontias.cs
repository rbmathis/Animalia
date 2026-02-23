using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Acontias;

/// <summary>
/// Abstract class for Acontias (genus).
/// NCBI TaxId: 156896
/// </summary>
public abstract class Acontias : Scincidae, IAcontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156896;

    /// <inheritdoc />
    public virtual string GenusName => "Acontias";

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
