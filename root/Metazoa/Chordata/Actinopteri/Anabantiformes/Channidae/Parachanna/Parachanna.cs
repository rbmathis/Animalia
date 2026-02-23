using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Parachanna;

/// <summary>
/// Abstract class for Parachanna (genus).
/// NCBI TaxId: 215403
/// </summary>
public abstract class Parachanna : Channidae, IParachanna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachanna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215403;

    /// <inheritdoc />
    public virtual string GenusName => "Parachanna";

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
