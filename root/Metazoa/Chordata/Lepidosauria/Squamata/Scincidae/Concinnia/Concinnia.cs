using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Concinnia;

/// <summary>
/// Abstract class for Concinnia (genus).
/// NCBI TaxId: 1540127
/// </summary>
public abstract class Concinnia : Scincidae, IConcinnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Concinnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540127;

    /// <inheritdoc />
    public virtual string GenusName => "Concinnia";

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
