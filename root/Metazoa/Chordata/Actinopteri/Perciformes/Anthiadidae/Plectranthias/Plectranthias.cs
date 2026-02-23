using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Plectranthias;

/// <summary>
/// Abstract class for Plectranthias (genus).
/// NCBI TaxId: 223807
/// </summary>
public abstract class Plectranthias : Anthiadidae, IPlectranthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectranthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223807;

    /// <inheritdoc />
    public virtual string GenusName => "Plectranthias";

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
