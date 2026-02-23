using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leptoancistrus;

/// <summary>
/// Abstract class for Leptoancistrus (genus).
/// NCBI TaxId: 1633177
/// </summary>
public abstract class Leptoancistrus : Loricariidae, ILeptoancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633177;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoancistrus";

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
