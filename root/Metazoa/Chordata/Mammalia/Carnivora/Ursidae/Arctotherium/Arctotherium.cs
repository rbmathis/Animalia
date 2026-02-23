using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctotherium;

/// <summary>
/// Abstract class for Arctotherium (genus).
/// NCBI TaxId: 1825729
/// </summary>
public abstract class Arctotherium : Ursidae, IArctotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1825729;

    /// <inheritdoc />
    public virtual string GenusName => "Arctotherium";

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
