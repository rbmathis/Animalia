using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Protocheirodon;

/// <summary>
/// Abstract class for Protocheirodon (genus).
/// NCBI TaxId: 2283135
/// </summary>
public abstract class Protocheirodon : Characidae, IProtocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2283135;

    /// <inheritdoc />
    public virtual string GenusName => "Protocheirodon";

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
