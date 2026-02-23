using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Cryptancistrus;

/// <summary>
/// Abstract class for Cryptancistrus (genus).
/// NCBI TaxId: 2071348
/// </summary>
public abstract class Cryptancistrus : Loricariidae, ICryptancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2071348;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptancistrus";

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
