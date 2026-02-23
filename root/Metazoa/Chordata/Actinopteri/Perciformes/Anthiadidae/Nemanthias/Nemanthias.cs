using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Nemanthias;

/// <summary>
/// Abstract class for Nemanthias (genus).
/// NCBI TaxId: 428435
/// </summary>
public abstract class Nemanthias : Anthiadidae, INemanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428435;

    /// <inheritdoc />
    public virtual string GenusName => "Nemanthias";

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
