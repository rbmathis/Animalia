using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Acantholatris;

/// <summary>
/// Abstract class for Acantholatris (genus).
/// NCBI TaxId: 76918
/// </summary>
public abstract class Acantholatris : Cheilodactylidae, IAcantholatris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantholatris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76918;

    /// <inheritdoc />
    public virtual string GenusName => "Acantholatris";

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
