using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scarthyla;

/// <summary>
/// Abstract class for Scarthyla (genus).
/// NCBI TaxId: 248875
/// </summary>
public abstract class Scarthyla : Hylidae, IScarthyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scarthyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248875;

    /// <inheritdoc />
    public virtual string GenusName => "Scarthyla";

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
