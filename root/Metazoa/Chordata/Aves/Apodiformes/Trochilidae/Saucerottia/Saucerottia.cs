using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Saucerottia;

/// <summary>
/// Abstract class for Saucerottia (genus).
/// NCBI TaxId: 2817432
/// </summary>
public abstract class Saucerottia : Trochilidae, ISaucerottia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saucerottia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817432;

    /// <inheritdoc />
    public virtual string GenusName => "Saucerottia";

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
