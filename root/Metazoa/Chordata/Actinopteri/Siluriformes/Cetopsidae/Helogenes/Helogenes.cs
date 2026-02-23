using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Helogenes;

/// <summary>
/// Abstract class for Helogenes (genus).
/// NCBI TaxId: 77842
/// </summary>
public abstract class Helogenes : Cetopsidae, IHelogenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helogenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77842;

    /// <inheritdoc />
    public virtual string GenusName => "Helogenes";

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
