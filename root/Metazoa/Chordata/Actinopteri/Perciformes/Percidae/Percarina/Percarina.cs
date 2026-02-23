using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percarina;

/// <summary>
/// Abstract class for Percarina (genus).
/// NCBI TaxId: 1169890
/// </summary>
public abstract class Percarina : Percidae, IPercarina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percarina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1169890;

    /// <inheritdoc />
    public virtual string GenusName => "Percarina";

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
