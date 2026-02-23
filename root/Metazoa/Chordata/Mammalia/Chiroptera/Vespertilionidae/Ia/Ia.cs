using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Ia;

/// <summary>
/// Abstract class for Ia (genus).
/// NCBI TaxId: 360966
/// </summary>
public abstract class Ia : Vespertilionidae, IIa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360966;

    /// <inheritdoc />
    public virtual string GenusName => "Ia";

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
