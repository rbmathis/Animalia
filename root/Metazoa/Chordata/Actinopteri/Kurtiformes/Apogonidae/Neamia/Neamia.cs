using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Neamia;

/// <summary>
/// Abstract class for Neamia (genus).
/// NCBI TaxId: 1910792
/// </summary>
public abstract class Neamia : Apogonidae, INeamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1910792;

    /// <inheritdoc />
    public virtual string GenusName => "Neamia";

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
