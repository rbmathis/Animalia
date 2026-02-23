using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Harpactes;

/// <summary>
/// Abstract class for Harpactes (genus).
/// NCBI TaxId: 57418
/// </summary>
public abstract class Harpactes : Trogonidae, IHarpactes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpactes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57418;

    /// <inheritdoc />
    public virtual string GenusName => "Harpactes";

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
