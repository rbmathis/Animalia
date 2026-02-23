using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae.Walkerana;

/// <summary>
/// Abstract class for Walkerana (genus).
/// NCBI TaxId: 1767671
/// </summary>
public abstract class Walkerana : Ranixalidae, IWalkerana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Walkerana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1767671;

    /// <inheritdoc />
    public virtual string GenusName => "Walkerana";

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
