using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Semaprochilodus;

/// <summary>
/// Abstract class for Semaprochilodus (genus).
/// NCBI TaxId: 143039
/// </summary>
public abstract class Semaprochilodus : Prochilodontidae, ISemaprochilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semaprochilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143039;

    /// <inheritdoc />
    public virtual string GenusName => "Semaprochilodus";

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
