using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Bathybagrus;

/// <summary>
/// Abstract class for Bathybagrus (genus).
/// NCBI TaxId: 390419
/// </summary>
public abstract class Bathybagrus : Claroteidae, IBathybagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathybagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390419;

    /// <inheritdoc />
    public virtual string GenusName => "Bathybagrus";

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
