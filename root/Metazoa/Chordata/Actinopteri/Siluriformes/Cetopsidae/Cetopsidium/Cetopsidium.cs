using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cetopsidae.Cetopsidium;

/// <summary>
/// Abstract class for Cetopsidium (genus).
/// NCBI TaxId: 691959
/// </summary>
public abstract class Cetopsidium : Cetopsidae, ICetopsidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetopsidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691959;

    /// <inheritdoc />
    public virtual string GenusName => "Cetopsidium";

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
