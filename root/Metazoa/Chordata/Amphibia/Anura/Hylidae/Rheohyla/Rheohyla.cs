using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Rheohyla;

/// <summary>
/// Abstract class for Rheohyla (genus).
/// NCBI TaxId: 2491337
/// </summary>
public abstract class Rheohyla : Hylidae, IRheohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491337;

    /// <inheritdoc />
    public virtual string GenusName => "Rheohyla";

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
