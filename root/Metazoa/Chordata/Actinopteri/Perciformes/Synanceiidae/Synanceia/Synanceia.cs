using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceia;

/// <summary>
/// Abstract class for Synanceia (genus).
/// NCBI TaxId: 13278
/// </summary>
public abstract class Synanceia : Synanceiidae, ISynanceia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synanceia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13278;

    /// <inheritdoc />
    public virtual string GenusName => "Synanceia";

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
