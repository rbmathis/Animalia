using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Pseudopungtungia;

/// <summary>
/// Abstract class for Pseudopungtungia (genus).
/// NCBI TaxId: 497913
/// </summary>
public abstract class Pseudopungtungia : Gobionidae, IPseudopungtungia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopungtungia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497913;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopungtungia";

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
