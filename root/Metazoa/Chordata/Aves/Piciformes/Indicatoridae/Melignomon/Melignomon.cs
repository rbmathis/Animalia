using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Melignomon;

/// <summary>
/// Abstract class for Melignomon (genus).
/// NCBI TaxId: 1002801
/// </summary>
public abstract class Melignomon : Indicatoridae, IMelignomon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melignomon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002801;

    /// <inheritdoc />
    public virtual string GenusName => "Melignomon";

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
