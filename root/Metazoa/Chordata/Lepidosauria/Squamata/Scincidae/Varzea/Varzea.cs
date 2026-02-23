using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Varzea;

/// <summary>
/// Abstract class for Varzea (genus).
/// NCBI TaxId: 1190636
/// </summary>
public abstract class Varzea : Scincidae, IVarzea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Varzea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1190636;

    /// <inheritdoc />
    public virtual string GenusName => "Varzea";

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
