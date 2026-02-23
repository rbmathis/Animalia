using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Nyctibates;

/// <summary>
/// Abstract class for Nyctibates (genus).
/// NCBI TaxId: 333696
/// </summary>
public abstract class Nyctibates : Arthroleptidae, INyctibates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctibates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 333696;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctibates";

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
