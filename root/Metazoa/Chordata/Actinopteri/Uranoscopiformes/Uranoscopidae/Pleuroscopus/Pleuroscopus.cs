using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Pleuroscopus;

/// <summary>
/// Abstract class for Pleuroscopus (genus).
/// NCBI TaxId: 2578403
/// </summary>
public abstract class Pleuroscopus : Uranoscopidae, IPleuroscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuroscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578403;

    /// <inheritdoc />
    public virtual string GenusName => "Pleuroscopus";

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
