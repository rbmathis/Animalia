using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Urocyon;

/// <summary>
/// Abstract class for Urocyon (genus).
/// NCBI TaxId: 55039
/// </summary>
public abstract class Urocyon : Canidae, IUrocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55039;

    /// <inheritdoc />
    public virtual string GenusName => "Urocyon";

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
