using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Prochilodontidae.Prochilodus;

/// <summary>
/// Abstract class for Prochilodus (genus).
/// NCBI TaxId: 27694
/// </summary>
public abstract class Prochilodus : Prochilodontidae, IProchilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prochilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27694;

    /// <inheritdoc />
    public virtual string GenusName => "Prochilodus";

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
