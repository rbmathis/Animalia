using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Phantasmarana;

/// <summary>
/// Abstract class for Phantasmarana (genus).
/// NCBI TaxId: 2838215
/// </summary>
public abstract class Phantasmarana : Hylodidae, IPhantasmarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phantasmarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2838215;

    /// <inheritdoc />
    public virtual string GenusName => "Phantasmarana";

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
