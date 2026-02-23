using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Alticus;

/// <summary>
/// Abstract class for Alticus (genus).
/// NCBI TaxId: 879681
/// </summary>
public abstract class Alticus : Blenniidae, IAlticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879681;

    /// <inheritdoc />
    public virtual string GenusName => "Alticus";

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
