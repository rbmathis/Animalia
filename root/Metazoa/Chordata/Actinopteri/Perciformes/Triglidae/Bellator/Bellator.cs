using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Bellator;

/// <summary>
/// Abstract class for Bellator (genus).
/// NCBI TaxId: 875784
/// </summary>
public abstract class Bellator : Triglidae, IBellator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bellator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875784;

    /// <inheritdoc />
    public virtual string GenusName => "Bellator";

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
