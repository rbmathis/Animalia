using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Kathetostoma;

/// <summary>
/// Abstract class for Kathetostoma (genus).
/// NCBI TaxId: 348045
/// </summary>
public abstract class Kathetostoma : Uranoscopidae, IKathetostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kathetostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 348045;

    /// <inheritdoc />
    public virtual string GenusName => "Kathetostoma";

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
