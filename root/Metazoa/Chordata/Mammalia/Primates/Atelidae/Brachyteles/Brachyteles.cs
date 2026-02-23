using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Brachyteles;

/// <summary>
/// Abstract class for Brachyteles (genus).
/// NCBI TaxId: 30593
/// </summary>
public abstract class Brachyteles : Atelidae, IBrachyteles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyteles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30593;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyteles";

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
