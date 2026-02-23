using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Trigla;

/// <summary>
/// Abstract class for Trigla (genus).
/// NCBI TaxId: 27775
/// </summary>
public abstract class Trigla : Triglidae, ITrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27775;

    /// <inheritdoc />
    public virtual string GenusName => "Trigla";

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
