using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Adelomyia;

/// <summary>
/// Abstract class for Adelomyia (genus).
/// NCBI TaxId: 304593
/// </summary>
public abstract class Adelomyia : Trochilidae, IAdelomyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelomyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304593;

    /// <inheritdoc />
    public virtual string GenusName => "Adelomyia";

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
