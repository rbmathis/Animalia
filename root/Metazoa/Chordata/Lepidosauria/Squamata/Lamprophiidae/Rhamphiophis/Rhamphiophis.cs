using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Rhamphiophis;

/// <summary>
/// Abstract class for Rhamphiophis (genus).
/// NCBI TaxId: 39150
/// </summary>
public abstract class Rhamphiophis : Lamprophiidae, IRhamphiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39150;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphiophis";

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
