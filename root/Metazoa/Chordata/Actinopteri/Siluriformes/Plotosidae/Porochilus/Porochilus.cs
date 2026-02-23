using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Porochilus;

/// <summary>
/// Abstract class for Porochilus (genus).
/// NCBI TaxId: 301281
/// </summary>
public abstract class Porochilus : Plotosidae, IPorochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 301281;

    /// <inheritdoc />
    public virtual string GenusName => "Porochilus";

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
