using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Teratohyla;

/// <summary>
/// Abstract class for Teratohyla (genus).
/// NCBI TaxId: 715388
/// </summary>
public abstract class Teratohyla : Centrolenidae, ITeratohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teratohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715388;

    /// <inheritdoc />
    public virtual string GenusName => "Teratohyla";

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
