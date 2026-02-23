using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Glyptauchen;

/// <summary>
/// Abstract class for Glyptauchen (genus).
/// NCBI TaxId: 1680624
/// </summary>
public abstract class Glyptauchen : Tetrarogidae, IGlyptauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1680624;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptauchen";

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
