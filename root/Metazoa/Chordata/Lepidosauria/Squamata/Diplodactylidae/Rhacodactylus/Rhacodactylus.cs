using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Rhacodactylus;

/// <summary>
/// Abstract class for Rhacodactylus (genus).
/// NCBI TaxId: 95121
/// </summary>
public abstract class Rhacodactylus : Diplodactylidae, IRhacodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhacodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95121;

    /// <inheritdoc />
    public virtual string GenusName => "Rhacodactylus";

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
