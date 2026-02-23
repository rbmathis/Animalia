using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Protogobiesox;

/// <summary>
/// Abstract class for Protogobiesox (genus).
/// NCBI TaxId: 1930300
/// </summary>
public abstract class Protogobiesox : Gobiesocidae, IProtogobiesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protogobiesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1930300;

    /// <inheritdoc />
    public virtual string GenusName => "Protogobiesox";

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
