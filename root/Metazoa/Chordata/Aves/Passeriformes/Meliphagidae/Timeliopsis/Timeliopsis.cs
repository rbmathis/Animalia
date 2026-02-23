using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Timeliopsis;

/// <summary>
/// Abstract class for Timeliopsis (genus).
/// NCBI TaxId: 266381
/// </summary>
public abstract class Timeliopsis : Meliphagidae, ITimeliopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Timeliopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266381;

    /// <inheritdoc />
    public virtual string GenusName => "Timeliopsis";

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
