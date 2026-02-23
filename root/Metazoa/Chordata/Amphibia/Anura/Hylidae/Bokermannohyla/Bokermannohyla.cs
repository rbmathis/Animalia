using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bokermannohyla;

/// <summary>
/// Abstract class for Bokermannohyla (genus).
/// NCBI TaxId: 374066
/// </summary>
public abstract class Bokermannohyla : Hylidae, IBokermannohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bokermannohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374066;

    /// <inheritdoc />
    public virtual string GenusName => "Bokermannohyla";

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
