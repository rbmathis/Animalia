using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Coleodactylus;

/// <summary>
/// Abstract class for Coleodactylus (genus).
/// NCBI TaxId: 341735
/// </summary>
public abstract class Coleodactylus : Sphaerodactylidae, IColeodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coleodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341735;

    /// <inheritdoc />
    public virtual string GenusName => "Coleodactylus";

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
