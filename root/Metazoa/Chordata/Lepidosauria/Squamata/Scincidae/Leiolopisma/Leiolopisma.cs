using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leiolopisma;

/// <summary>
/// Abstract class for Leiolopisma (genus).
/// NCBI TaxId: 105719
/// </summary>
public abstract class Leiolopisma : Scincidae, ILeiolopisma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiolopisma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105719;

    /// <inheritdoc />
    public virtual string GenusName => "Leiolopisma";

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
