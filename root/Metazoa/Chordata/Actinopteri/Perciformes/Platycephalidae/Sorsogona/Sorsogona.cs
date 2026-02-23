using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Sorsogona;

/// <summary>
/// Abstract class for Sorsogona (genus).
/// NCBI TaxId: 1230787
/// </summary>
public abstract class Sorsogona : Platycephalidae, ISorsogona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sorsogona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230787;

    /// <inheritdoc />
    public virtual string GenusName => "Sorsogona";

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
