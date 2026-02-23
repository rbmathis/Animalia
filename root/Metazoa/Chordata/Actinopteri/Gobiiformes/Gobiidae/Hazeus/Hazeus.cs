using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hazeus;

/// <summary>
/// Abstract class for Hazeus (genus).
/// NCBI TaxId: 1976951
/// </summary>
public abstract class Hazeus : Gobiidae, IHazeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hazeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1976951;

    /// <inheritdoc />
    public virtual string GenusName => "Hazeus";

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
