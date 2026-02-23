using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Hemicetopsis;

/// <summary>
/// Abstract class for Hemicetopsis (genus).
/// NCBI TaxId: 36709
/// </summary>
public abstract class Hemicetopsis : Cetopsidae, IHemicetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemicetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36709;

    /// <inheritdoc />
    public virtual string GenusName => "Hemicetopsis";

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
