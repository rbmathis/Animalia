using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Saurodactylus;

/// <summary>
/// Abstract class for Saurodactylus (genus).
/// NCBI TaxId: 456483
/// </summary>
public abstract class Saurodactylus : Sphaerodactylidae, ISaurodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saurodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456483;

    /// <inheritdoc />
    public virtual string GenusName => "Saurodactylus";

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
