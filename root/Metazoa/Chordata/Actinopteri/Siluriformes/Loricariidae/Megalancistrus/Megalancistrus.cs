using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Megalancistrus;

/// <summary>
/// Abstract class for Megalancistrus (genus).
/// NCBI TaxId: 745515
/// </summary>
public abstract class Megalancistrus : Loricariidae, IMegalancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745515;

    /// <inheritdoc />
    public virtual string GenusName => "Megalancistrus";

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
