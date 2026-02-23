using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Characidium;

/// <summary>
/// Abstract class for Characidium (genus).
/// NCBI TaxId: 42560
/// </summary>
public abstract class Characidium : Crenuchidae, ICharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Characidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42560;

    /// <inheritdoc />
    public virtual string GenusName => "Characidium";

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
