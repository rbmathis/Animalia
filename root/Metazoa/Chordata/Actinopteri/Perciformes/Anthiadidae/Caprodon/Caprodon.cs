using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Caprodon;

/// <summary>
/// Abstract class for Caprodon (genus).
/// NCBI TaxId: 334910
/// </summary>
public abstract class Caprodon : Anthiadidae, ICaprodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caprodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334910;

    /// <inheritdoc />
    public virtual string GenusName => "Caprodon";

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
