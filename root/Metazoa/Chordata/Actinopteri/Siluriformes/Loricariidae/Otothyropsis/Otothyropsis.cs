using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Otothyropsis;

/// <summary>
/// Abstract class for Otothyropsis (genus).
/// NCBI TaxId: 510937
/// </summary>
public abstract class Otothyropsis : Loricariidae, IOtothyropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otothyropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510937;

    /// <inheritdoc />
    public virtual string GenusName => "Otothyropsis";

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
