using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Myersiohyla;

/// <summary>
/// Abstract class for Myersiohyla (genus).
/// NCBI TaxId: 374067
/// </summary>
public abstract class Myersiohyla : Hylidae, IMyersiohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myersiohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374067;

    /// <inheritdoc />
    public virtual string GenusName => "Myersiohyla";

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
