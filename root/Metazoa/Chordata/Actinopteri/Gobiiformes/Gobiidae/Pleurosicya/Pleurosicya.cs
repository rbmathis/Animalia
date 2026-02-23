using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pleurosicya;

/// <summary>
/// Abstract class for Pleurosicya (genus).
/// NCBI TaxId: 595629
/// </summary>
public abstract class Pleurosicya : Gobiidae, IPleurosicya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleurosicya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 595629;

    /// <inheritdoc />
    public virtual string GenusName => "Pleurosicya";

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
