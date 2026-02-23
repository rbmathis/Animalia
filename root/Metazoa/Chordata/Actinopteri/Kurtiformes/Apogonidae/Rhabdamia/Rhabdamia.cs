using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Rhabdamia;

/// <summary>
/// Abstract class for Rhabdamia (genus).
/// NCBI TaxId: 587068
/// </summary>
public abstract class Rhabdamia : Apogonidae, IRhabdamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587068;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdamia";

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
