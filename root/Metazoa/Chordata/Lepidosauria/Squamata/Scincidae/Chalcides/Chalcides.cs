using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Chalcides;

/// <summary>
/// Abstract class for Chalcides (genus).
/// NCBI TaxId: 63295
/// </summary>
public abstract class Chalcides : Scincidae, IChalcides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63295;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcides";

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
