using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Lithodytes;

/// <summary>
/// Abstract class for Lithodytes (genus).
/// NCBI TaxId: 44374
/// </summary>
public abstract class Lithodytes : Leptodactylidae, ILithodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44374;

    /// <inheritdoc />
    public virtual string GenusName => "Lithodytes";

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
