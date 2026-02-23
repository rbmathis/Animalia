using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Morwong;

/// <summary>
/// Abstract class for Morwong (genus).
/// NCBI TaxId: 3056066
/// </summary>
public abstract class Morwong : Latridae, IMorwong
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morwong";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056066;

    /// <inheritdoc />
    public virtual string GenusName => "Morwong";

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
