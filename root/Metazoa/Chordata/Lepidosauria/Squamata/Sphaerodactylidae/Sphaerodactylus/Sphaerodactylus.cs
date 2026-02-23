using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Sphaerodactylus;

/// <summary>
/// Abstract class for Sphaerodactylus (genus).
/// NCBI TaxId: 53271
/// </summary>
public abstract class Sphaerodactylus : Sphaerodactylidae, ISphaerodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaerodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 53271;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaerodactylus";

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
