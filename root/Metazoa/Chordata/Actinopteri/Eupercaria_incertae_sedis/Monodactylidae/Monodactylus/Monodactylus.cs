using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae.Monodactylus;

/// <summary>
/// Abstract class for Monodactylus (genus).
/// NCBI TaxId: 334895
/// </summary>
public abstract class Monodactylus : Monodactylidae, IMonodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334895;

    /// <inheritdoc />
    public virtual string GenusName => "Monodactylus";

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
