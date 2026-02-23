using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Pelates;

/// <summary>
/// Abstract class for Pelates (genus).
/// NCBI TaxId: 546548
/// </summary>
public abstract class Pelates : Terapontidae, IPelates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 546548;

    /// <inheritdoc />
    public virtual string GenusName => "Pelates";

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
