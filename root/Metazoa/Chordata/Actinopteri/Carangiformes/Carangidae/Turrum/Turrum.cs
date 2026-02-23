using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Turrum;

/// <summary>
/// Abstract class for Turrum (genus).
/// NCBI TaxId: 3040449
/// </summary>
public abstract class Turrum : Carangidae, ITurrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040449;

    /// <inheritdoc />
    public virtual string GenusName => "Turrum";

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
