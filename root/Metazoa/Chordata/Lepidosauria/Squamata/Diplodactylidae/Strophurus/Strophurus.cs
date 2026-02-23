using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Strophurus;

/// <summary>
/// Abstract class for Strophurus (genus).
/// NCBI TaxId: 71026
/// </summary>
public abstract class Strophurus : Diplodactylidae, IStrophurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strophurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71026;

    /// <inheritdoc />
    public virtual string GenusName => "Strophurus";

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
