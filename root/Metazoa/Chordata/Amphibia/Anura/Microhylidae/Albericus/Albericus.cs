using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Albericus;

/// <summary>
/// Abstract class for Albericus (genus).
/// NCBI TaxId: 480208
/// </summary>
public abstract class Albericus : Microhylidae, IAlbericus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Albericus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 480208;

    /// <inheritdoc />
    public virtual string GenusName => "Albericus";

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
