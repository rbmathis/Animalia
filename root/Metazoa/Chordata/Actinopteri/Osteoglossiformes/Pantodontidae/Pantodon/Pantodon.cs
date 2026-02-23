using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Pantodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Pantodontidae.Pantodon;

/// <summary>
/// Abstract class for Pantodon (genus).
/// NCBI TaxId: 8275
/// </summary>
public abstract class Pantodon : Pantodontidae, IPantodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8275;

    /// <inheritdoc />
    public virtual string GenusName => "Pantodon";

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
