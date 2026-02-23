using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Parvoscincus;

/// <summary>
/// Abstract class for Parvoscincus (genus).
/// NCBI TaxId: 999444
/// </summary>
public abstract class Parvoscincus : Scincidae, IParvoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 999444;

    /// <inheritdoc />
    public virtual string GenusName => "Parvoscincus";

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
