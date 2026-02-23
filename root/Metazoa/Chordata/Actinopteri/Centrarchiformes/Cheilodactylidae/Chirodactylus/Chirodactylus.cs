using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Chirodactylus;

/// <summary>
/// Abstract class for Chirodactylus (genus).
/// NCBI TaxId: 76922
/// </summary>
public abstract class Chirodactylus : Cheilodactylidae, IChirodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76922;

    /// <inheritdoc />
    public virtual string GenusName => "Chirodactylus";

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
