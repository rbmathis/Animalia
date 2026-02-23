using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Sander;

/// <summary>
/// Abstract class for Sander (genus).
/// NCBI TaxId: 283033
/// </summary>
public abstract class Sander : Percidae, ISander
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sander";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 283033;

    /// <inheritdoc />
    public virtual string GenusName => "Sander";

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
