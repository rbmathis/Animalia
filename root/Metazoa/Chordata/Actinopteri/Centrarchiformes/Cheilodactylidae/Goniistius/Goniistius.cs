using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Goniistius;

/// <summary>
/// Abstract class for Goniistius (genus).
/// NCBI TaxId: 215376
/// </summary>
public abstract class Goniistius : Cheilodactylidae, IGoniistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goniistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215376;

    /// <inheritdoc />
    public virtual string GenusName => "Goniistius";

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
