using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Abstract class for Leptodactylus (genus).
/// NCBI TaxId: 47563
/// </summary>
public abstract class Leptodactylus : Leptodactylidae, ILeptodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47563;

    /// <inheritdoc />
    public virtual string GenusName => "Leptodactylus";

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
