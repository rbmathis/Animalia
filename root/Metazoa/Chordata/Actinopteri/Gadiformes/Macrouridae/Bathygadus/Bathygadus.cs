using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Bathygadus;

/// <summary>
/// Abstract class for Bathygadus (genus).
/// NCBI TaxId: 332420
/// </summary>
public abstract class Bathygadus : Macrouridae, IBathygadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathygadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332420;

    /// <inheritdoc />
    public virtual string GenusName => "Bathygadus";

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
