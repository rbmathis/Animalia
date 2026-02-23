using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Jacamaralcyon;

/// <summary>
/// Abstract class for Jacamaralcyon (genus).
/// NCBI TaxId: 1577978
/// </summary>
public abstract class Jacamaralcyon : Galbulidae, IJacamaralcyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jacamaralcyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1577978;

    /// <inheritdoc />
    public virtual string GenusName => "Jacamaralcyon";

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
