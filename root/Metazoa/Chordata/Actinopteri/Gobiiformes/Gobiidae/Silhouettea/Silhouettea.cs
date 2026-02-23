using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Silhouettea;

/// <summary>
/// Abstract class for Silhouettea (genus).
/// NCBI TaxId: 1365714
/// </summary>
public abstract class Silhouettea : Gobiidae, ISilhouettea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silhouettea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365714;

    /// <inheritdoc />
    public virtual string GenusName => "Silhouettea";

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
