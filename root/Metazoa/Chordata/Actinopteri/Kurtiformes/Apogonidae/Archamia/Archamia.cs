using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Archamia;

/// <summary>
/// Abstract class for Archamia (genus).
/// NCBI TaxId: 512331
/// </summary>
public abstract class Archamia : Apogonidae, IArchamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 512331;

    /// <inheritdoc />
    public virtual string GenusName => "Archamia";

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
