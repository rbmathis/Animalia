using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Mimagoniates;

/// <summary>
/// Abstract class for Mimagoniates (genus).
/// NCBI TaxId: 304056
/// </summary>
public abstract class Mimagoniates : Stevardiidae, IMimagoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mimagoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304056;

    /// <inheritdoc />
    public virtual string GenusName => "Mimagoniates";

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
