using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nesorohyla;

/// <summary>
/// Abstract class for Nesorohyla (genus).
/// NCBI TaxId: 2593401
/// </summary>
public abstract class Nesorohyla : Hylidae, INesorohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesorohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2593401;

    /// <inheritdoc />
    public virtual string GenusName => "Nesorohyla";

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
