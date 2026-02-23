using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Vansonia;

/// <summary>
/// Abstract class for Vansonia (genus).
/// NCBI TaxId: 2778577
/// </summary>
public abstract class Vansonia : Vespertilionidae, IVansonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vansonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2778577;

    /// <inheritdoc />
    public virtual string GenusName => "Vansonia";

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
