using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Ichthyscopus;

/// <summary>
/// Abstract class for Ichthyscopus (genus).
/// NCBI TaxId: 270581
/// </summary>
public abstract class Ichthyscopus : Uranoscopidae, IIchthyscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270581;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyscopus";

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
