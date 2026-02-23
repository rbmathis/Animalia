using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Typhlacontias;

/// <summary>
/// Abstract class for Typhlacontias (genus).
/// NCBI TaxId: 230628
/// </summary>
public abstract class Typhlacontias : Scincidae, ITyphlacontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlacontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230628;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlacontias";

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
