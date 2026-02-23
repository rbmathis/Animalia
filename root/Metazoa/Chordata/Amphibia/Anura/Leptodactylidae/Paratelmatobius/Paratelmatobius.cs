using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Paratelmatobius;

/// <summary>
/// Abstract class for Paratelmatobius (genus).
/// NCBI TaxId: 356317
/// </summary>
public abstract class Paratelmatobius : Leptodactylidae, IParatelmatobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratelmatobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356317;

    /// <inheritdoc />
    public virtual string GenusName => "Paratelmatobius";

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
