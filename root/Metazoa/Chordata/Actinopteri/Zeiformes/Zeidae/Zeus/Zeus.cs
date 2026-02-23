using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus;

/// <summary>
/// Abstract class for Zeus (genus).
/// NCBI TaxId: 64107
/// </summary>
public abstract class Zeus : Zeidae, IZeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64107;

    /// <inheritdoc />
    public virtual string GenusName => "Zeus";

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
