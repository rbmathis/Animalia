using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Henochilus;

/// <summary>
/// Abstract class for Henochilus (genus).
/// NCBI TaxId: 217207
/// </summary>
public abstract class Henochilus : Characidae, IHenochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Henochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 217207;

    /// <inheritdoc />
    public virtual string GenusName => "Henochilus";

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
