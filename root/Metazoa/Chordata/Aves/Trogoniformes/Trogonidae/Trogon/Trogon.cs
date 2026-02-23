using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Trogon;

/// <summary>
/// Abstract class for Trogon (genus).
/// NCBI TaxId: 56310
/// </summary>
public abstract class Trogon : Trogonidae, ITrogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56310;

    /// <inheritdoc />
    public virtual string GenusName => "Trogon";

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
