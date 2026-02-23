using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Dendrophysa;

/// <summary>
/// Abstract class for Dendrophysa (genus).
/// NCBI TaxId: 435233
/// </summary>
public abstract class Dendrophysa : Sciaenidae, IDendrophysa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrophysa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435233;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrophysa";

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
