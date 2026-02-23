using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Muraena;

/// <summary>
/// Abstract class for Muraena (genus).
/// NCBI TaxId: 46661
/// </summary>
public abstract class Muraena : Muraenidae, IMuraena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muraena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46661;

    /// <inheritdoc />
    public virtual string GenusName => "Muraena";

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
