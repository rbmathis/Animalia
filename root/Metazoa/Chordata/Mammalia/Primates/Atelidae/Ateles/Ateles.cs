using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Abstract class for Ateles (genus).
/// NCBI TaxId: 9506
/// </summary>
public abstract class Ateles : Atelidae, IAteles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ateles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9506;

    /// <inheritdoc />
    public virtual string GenusName => "Ateles";

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
