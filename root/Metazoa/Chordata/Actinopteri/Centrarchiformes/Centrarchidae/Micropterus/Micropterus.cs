using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Micropterus;

/// <summary>
/// Abstract class for Micropterus (genus).
/// NCBI TaxId: 27705
/// </summary>
public abstract class Micropterus : Centrarchidae, IMicropterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27705;

    /// <inheritdoc />
    public virtual string GenusName => "Micropterus";

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
