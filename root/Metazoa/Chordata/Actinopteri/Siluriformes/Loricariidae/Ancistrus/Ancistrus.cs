using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ancistrus;

/// <summary>
/// Abstract class for Ancistrus (genus).
/// NCBI TaxId: 52071
/// </summary>
public abstract class Ancistrus : Loricariidae, IAncistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52071;

    /// <inheritdoc />
    public virtual string GenusName => "Ancistrus";

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
