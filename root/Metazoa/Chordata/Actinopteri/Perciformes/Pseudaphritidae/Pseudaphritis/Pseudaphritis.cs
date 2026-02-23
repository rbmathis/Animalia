using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pseudaphritidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pseudaphritidae.Pseudaphritis;

/// <summary>
/// Abstract class for Pseudaphritis (genus).
/// NCBI TaxId: 56721
/// </summary>
public abstract class Pseudaphritis : Pseudaphritidae, IPseudaphritis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudaphritis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56721;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudaphritis";

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
