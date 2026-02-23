using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Alexteroon;

/// <summary>
/// Abstract class for Alexteroon (genus).
/// NCBI TaxId: 356256
/// </summary>
public abstract class Alexteroon : Hyperoliidae, IAlexteroon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alexteroon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356256;

    /// <inheritdoc />
    public virtual string GenusName => "Alexteroon";

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
