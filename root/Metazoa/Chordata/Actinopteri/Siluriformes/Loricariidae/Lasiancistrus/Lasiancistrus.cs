using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lasiancistrus;

/// <summary>
/// Abstract class for Lasiancistrus (genus).
/// NCBI TaxId: 337788
/// </summary>
public abstract class Lasiancistrus : Loricariidae, ILasiancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lasiancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337788;

    /// <inheritdoc />
    public virtual string GenusName => "Lasiancistrus";

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
