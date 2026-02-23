using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Nemadactylus;

/// <summary>
/// Abstract class for Nemadactylus (genus).
/// NCBI TaxId: 76926
/// </summary>
public abstract class Nemadactylus : Cheilodactylidae, INemadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76926;

    /// <inheritdoc />
    public virtual string GenusName => "Nemadactylus";

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
