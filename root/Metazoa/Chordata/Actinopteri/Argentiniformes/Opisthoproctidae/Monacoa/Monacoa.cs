using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Monacoa;

/// <summary>
/// Abstract class for Monacoa (genus).
/// NCBI TaxId: 1780241
/// </summary>
public abstract class Monacoa : Opisthoproctidae, IMonacoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monacoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1780241;

    /// <inheritdoc />
    public virtual string GenusName => "Monacoa";

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
