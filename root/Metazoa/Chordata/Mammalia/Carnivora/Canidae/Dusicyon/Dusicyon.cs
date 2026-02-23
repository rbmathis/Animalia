using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Dusicyon;

/// <summary>
/// Abstract class for Dusicyon (genus).
/// NCBI TaxId: 9619
/// </summary>
public abstract class Dusicyon : Canidae, IDusicyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dusicyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9619;

    /// <inheritdoc />
    public virtual string GenusName => "Dusicyon";

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
