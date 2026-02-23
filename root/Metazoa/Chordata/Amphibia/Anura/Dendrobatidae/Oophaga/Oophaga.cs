using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Oophaga;

/// <summary>
/// Abstract class for Oophaga (genus).
/// NCBI TaxId: 1004435
/// </summary>
public abstract class Oophaga : Dendrobatidae, IOophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004435;

    /// <inheritdoc />
    public virtual string GenusName => "Oophaga";

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
