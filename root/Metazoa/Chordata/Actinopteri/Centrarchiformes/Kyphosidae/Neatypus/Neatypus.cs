using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Neatypus;

/// <summary>
/// Abstract class for Neatypus (genus).
/// NCBI TaxId: 3362382
/// </summary>
public abstract class Neatypus : Kyphosidae, INeatypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neatypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362382;

    /// <inheritdoc />
    public virtual string GenusName => "Neatypus";

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
