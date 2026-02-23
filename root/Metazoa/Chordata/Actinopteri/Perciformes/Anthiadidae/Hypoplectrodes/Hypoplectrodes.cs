using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Hypoplectrodes;

/// <summary>
/// Abstract class for Hypoplectrodes (genus).
/// NCBI TaxId: 2696554
/// </summary>
public abstract class Hypoplectrodes : Anthiadidae, IHypoplectrodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoplectrodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696554;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoplectrodes";

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
