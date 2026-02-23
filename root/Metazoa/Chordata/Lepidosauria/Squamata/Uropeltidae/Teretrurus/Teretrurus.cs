using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Teretrurus;

/// <summary>
/// Abstract class for Teretrurus (genus).
/// NCBI TaxId: 1545961
/// </summary>
public abstract class Teretrurus : Uropeltidae, ITeretrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teretrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545961;

    /// <inheritdoc />
    public virtual string GenusName => "Teretrurus";

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
