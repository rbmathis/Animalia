using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dolichancistrus;

/// <summary>
/// Abstract class for Dolichancistrus (genus).
/// NCBI TaxId: 1633167
/// </summary>
public abstract class Dolichancistrus : Loricariidae, IDolichancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633167;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichancistrus";

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
