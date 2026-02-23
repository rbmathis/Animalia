using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Apaloderma;

/// <summary>
/// Abstract class for Apaloderma (genus).
/// NCBI TaxId: 57396
/// </summary>
public abstract class Apaloderma : Trogonidae, IApaloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apaloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57396;

    /// <inheritdoc />
    public virtual string GenusName => "Apaloderma";

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
