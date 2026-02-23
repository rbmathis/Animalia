using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Syncomistes;

/// <summary>
/// Abstract class for Syncomistes (genus).
/// NCBI TaxId: 1161380
/// </summary>
public abstract class Syncomistes : Terapontidae, ISyncomistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syncomistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1161380;

    /// <inheritdoc />
    public virtual string GenusName => "Syncomistes";

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
