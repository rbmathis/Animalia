using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Pseudoplectrurus;

/// <summary>
/// Abstract class for Pseudoplectrurus (genus).
/// NCBI TaxId: 2035170
/// </summary>
public abstract class Pseudoplectrurus : Uropeltidae, IPseudoplectrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoplectrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2035170;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoplectrurus";

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
