using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Apalharpactes;

/// <summary>
/// Abstract class for Apalharpactes (genus).
/// NCBI TaxId: 2820828
/// </summary>
public abstract class Apalharpactes : Trogonidae, IApalharpactes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apalharpactes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820828;

    /// <inheritdoc />
    public virtual string GenusName => "Apalharpactes";

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
