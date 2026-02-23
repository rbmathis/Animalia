using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Rupirana;

/// <summary>
/// Abstract class for Rupirana (genus).
/// NCBI TaxId: 1302556
/// </summary>
public abstract class Rupirana : Leptodactylidae, IRupirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rupirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1302556;

    /// <inheritdoc />
    public virtual string GenusName => "Rupirana";

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
