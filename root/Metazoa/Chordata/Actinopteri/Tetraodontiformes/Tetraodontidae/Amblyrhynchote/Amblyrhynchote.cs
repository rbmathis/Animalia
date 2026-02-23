using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Amblyrhynchote;

/// <summary>
/// Abstract class for Amblyrhynchote (genus).
/// NCBI TaxId: 3363384
/// </summary>
public abstract class Amblyrhynchote : Tetraodontidae, IAmblyrhynchote
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyrhynchote";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363384;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyrhynchote";

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
