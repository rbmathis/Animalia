using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Chrysocyon;

/// <summary>
/// Abstract class for Chrysocyon (genus).
/// NCBI TaxId: 68727
/// </summary>
public abstract class Chrysocyon : Canidae, IChrysocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68727;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysocyon";

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
