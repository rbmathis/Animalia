using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Aplodactylidae.Aplodactylus;

/// <summary>
/// Abstract class for Aplodactylus (genus).
/// NCBI TaxId: 82891
/// </summary>
public abstract class Aplodactylus : Aplodactylidae, IAplodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 82891;

    /// <inheritdoc />
    public virtual string GenusName => "Aplodactylus";

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
