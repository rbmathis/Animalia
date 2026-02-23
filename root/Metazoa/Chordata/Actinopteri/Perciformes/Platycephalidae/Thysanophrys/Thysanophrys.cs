using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Thysanophrys;

/// <summary>
/// Abstract class for Thysanophrys (genus).
/// NCBI TaxId: 1230803
/// </summary>
public abstract class Thysanophrys : Platycephalidae, IThysanophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thysanophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230803;

    /// <inheritdoc />
    public virtual string GenusName => "Thysanophrys";

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
