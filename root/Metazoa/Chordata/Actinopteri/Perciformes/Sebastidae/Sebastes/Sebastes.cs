using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastes;

/// <summary>
/// Abstract class for Sebastes (genus).
/// NCBI TaxId: 34820
/// </summary>
public abstract class Sebastes : Sebastidae, ISebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34820;

    /// <inheritdoc />
    public virtual string GenusName => "Sebastes";

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
