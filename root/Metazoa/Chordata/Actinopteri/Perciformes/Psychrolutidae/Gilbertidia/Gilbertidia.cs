using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Gilbertidia;

/// <summary>
/// Abstract class for Gilbertidia (genus).
/// NCBI TaxId: 2768303
/// </summary>
public abstract class Gilbertidia : Psychrolutidae, IGilbertidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gilbertidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768303;

    /// <inheritdoc />
    public virtual string GenusName => "Gilbertidia";

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
