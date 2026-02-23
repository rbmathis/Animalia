using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Enophrys;

/// <summary>
/// Abstract class for Enophrys (genus).
/// NCBI TaxId: 320616
/// </summary>
public abstract class Enophrys : Cottidae, IEnophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320616;

    /// <inheritdoc />
    public virtual string GenusName => "Enophrys";

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
