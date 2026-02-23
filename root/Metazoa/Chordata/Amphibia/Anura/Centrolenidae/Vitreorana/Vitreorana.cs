using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Vitreorana;

/// <summary>
/// Abstract class for Vitreorana (genus).
/// NCBI TaxId: 715369
/// </summary>
public abstract class Vitreorana : Centrolenidae, IVitreorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vitreorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715369;

    /// <inheritdoc />
    public virtual string GenusName => "Vitreorana";

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
