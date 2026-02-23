using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Oloplotosus;

/// <summary>
/// Abstract class for Oloplotosus (genus).
/// NCBI TaxId: 2943277
/// </summary>
public abstract class Oloplotosus : Plotosidae, IOloplotosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oloplotosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2943277;

    /// <inheritdoc />
    public virtual string GenusName => "Oloplotosus";

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
