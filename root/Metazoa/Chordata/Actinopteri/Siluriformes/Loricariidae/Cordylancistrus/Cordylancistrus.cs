using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Cordylancistrus;

/// <summary>
/// Abstract class for Cordylancistrus (genus).
/// NCBI TaxId: 1633163
/// </summary>
public abstract class Cordylancistrus : Loricariidae, ICordylancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cordylancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633163;

    /// <inheritdoc />
    public virtual string GenusName => "Cordylancistrus";

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
