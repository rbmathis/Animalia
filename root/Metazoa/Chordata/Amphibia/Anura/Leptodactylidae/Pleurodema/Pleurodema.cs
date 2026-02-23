using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pleurodema;

/// <summary>
/// Abstract class for Pleurodema (genus).
/// NCBI TaxId: 318408
/// </summary>
public abstract class Pleurodema : Leptodactylidae, IPleurodema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleurodema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318408;

    /// <inheritdoc />
    public virtual string GenusName => "Pleurodema";

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
