using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiancistrus;

/// <summary>
/// Abstract class for Hemiancistrus (genus).
/// NCBI TaxId: 52083
/// </summary>
public abstract class Hemiancistrus : Loricariidae, IHemiancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52083;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiancistrus";

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
