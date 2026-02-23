using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Teratoscincus;

/// <summary>
/// Abstract class for Teratoscincus (genus).
/// NCBI TaxId: 52168
/// </summary>
public abstract class Teratoscincus : Sphaerodactylidae, ITeratoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teratoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52168;

    /// <inheritdoc />
    public virtual string GenusName => "Teratoscincus";

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
