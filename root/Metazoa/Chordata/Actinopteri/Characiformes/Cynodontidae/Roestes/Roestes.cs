using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Cynodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Cynodontidae.Roestes;

/// <summary>
/// Abstract class for Roestes (genus).
/// NCBI TaxId: 930392
/// </summary>
public abstract class Roestes : Cynodontidae, IRoestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Roestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930392;

    /// <inheritdoc />
    public virtual string GenusName => "Roestes";

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
