using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Cheilodactylus;

/// <summary>
/// Abstract class for Cheilodactylus (genus).
/// NCBI TaxId: 76920
/// </summary>
public abstract class Cheilodactylus : Cheilodactylidae, ICheilodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76920;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilodactylus";

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
