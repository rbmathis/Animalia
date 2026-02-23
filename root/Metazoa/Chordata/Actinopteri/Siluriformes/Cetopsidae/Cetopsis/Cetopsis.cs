using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsis;

/// <summary>
/// Abstract class for Cetopsis (genus).
/// NCBI TaxId: 36711
/// </summary>
public abstract class Cetopsis : Cetopsidae, ICetopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36711;

    /// <inheritdoc />
    public virtual string GenusName => "Cetopsis";

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
