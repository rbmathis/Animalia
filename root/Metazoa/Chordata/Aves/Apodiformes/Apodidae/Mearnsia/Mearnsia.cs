using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Mearnsia;

/// <summary>
/// Abstract class for Mearnsia (genus).
/// NCBI TaxId: 3395422
/// </summary>
public abstract class Mearnsia : Apodidae, IMearnsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mearnsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3395422;

    /// <inheritdoc />
    public virtual string GenusName => "Mearnsia";

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
