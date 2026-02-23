using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Andeancistrus;

/// <summary>
/// Abstract class for Andeancistrus (genus).
/// NCBI TaxId: 2993302
/// </summary>
public abstract class Andeancistrus : Loricariidae, IAndeancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andeancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2993302;

    /// <inheritdoc />
    public virtual string GenusName => "Andeancistrus";

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
