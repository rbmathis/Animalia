using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Taeniamia;

/// <summary>
/// Abstract class for Taeniamia (genus).
/// NCBI TaxId: 1431515
/// </summary>
public abstract class Taeniamia : Apogonidae, ITaeniamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1431515;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniamia";

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
