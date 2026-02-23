using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae.Pholis;

/// <summary>
/// Abstract class for Pholis (genus).
/// NCBI TaxId: 56725
/// </summary>
public abstract class Pholis : Pholidae, IPholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56725;

    /// <inheritdoc />
    public virtual string GenusName => "Pholis";

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
