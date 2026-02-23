using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Ammocrypta;

/// <summary>
/// Abstract class for Ammocrypta (genus).
/// NCBI TaxId: 77139
/// </summary>
public abstract class Ammocrypta : Percidae, IAmmocrypta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammocrypta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77139;

    /// <inheritdoc />
    public virtual string GenusName => "Ammocrypta";

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
