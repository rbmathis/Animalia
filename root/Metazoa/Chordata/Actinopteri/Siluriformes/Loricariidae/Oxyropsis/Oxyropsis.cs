using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Oxyropsis;

/// <summary>
/// Abstract class for Oxyropsis (genus).
/// NCBI TaxId: 337537
/// </summary>
public abstract class Oxyropsis : Loricariidae, IOxyropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337537;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyropsis";

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
