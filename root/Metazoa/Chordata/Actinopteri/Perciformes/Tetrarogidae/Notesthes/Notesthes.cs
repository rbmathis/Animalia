using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Notesthes;

/// <summary>
/// Abstract class for Notesthes (genus).
/// NCBI TaxId: 390353
/// </summary>
public abstract class Notesthes : Tetrarogidae, INotesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390353;

    /// <inheritdoc />
    public virtual string GenusName => "Notesthes";

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
