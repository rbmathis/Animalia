using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Trigloporus;

/// <summary>
/// Abstract class for Trigloporus (genus).
/// NCBI TaxId: 426096
/// </summary>
public abstract class Trigloporus : Triglidae, ITrigloporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigloporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 426096;

    /// <inheritdoc />
    public virtual string GenusName => "Trigloporus";

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
