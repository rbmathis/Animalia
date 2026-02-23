using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pseudamia;

/// <summary>
/// Abstract class for Pseudamia (genus).
/// NCBI TaxId: 475182
/// </summary>
public abstract class Pseudamia : Apogonidae, IPseudamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475182;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudamia";

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
