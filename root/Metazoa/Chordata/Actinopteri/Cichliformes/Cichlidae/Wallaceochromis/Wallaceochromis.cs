using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Wallaceochromis;

/// <summary>
/// Abstract class for Wallaceochromis (genus).
/// NCBI TaxId: 2962740
/// </summary>
public abstract class Wallaceochromis : Cichlidae, IWallaceochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wallaceochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2962740;

    /// <inheritdoc />
    public virtual string GenusName => "Wallaceochromis";

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
