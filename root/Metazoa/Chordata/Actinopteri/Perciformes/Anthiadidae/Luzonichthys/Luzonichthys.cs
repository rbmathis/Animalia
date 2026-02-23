using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Luzonichthys;

/// <summary>
/// Abstract class for Luzonichthys (genus).
/// NCBI TaxId: 428433
/// </summary>
public abstract class Luzonichthys : Anthiadidae, ILuzonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luzonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428433;

    /// <inheritdoc />
    public virtual string GenusName => "Luzonichthys";

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
