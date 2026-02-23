using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Eutrigla;

/// <summary>
/// Abstract class for Eutrigla (genus).
/// NCBI TaxId: 426097
/// </summary>
public abstract class Eutrigla : Triglidae, IEutrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutrigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 426097;

    /// <inheritdoc />
    public virtual string GenusName => "Eutrigla";

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
