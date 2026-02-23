using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Micrenophrys;

/// <summary>
/// Abstract class for Micrenophrys (genus).
/// NCBI TaxId: 2821465
/// </summary>
public abstract class Micrenophrys : Cottidae, IMicrenophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrenophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821465;

    /// <inheritdoc />
    public virtual string GenusName => "Micrenophrys";

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
