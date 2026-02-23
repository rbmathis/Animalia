using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Trichosomus;

/// <summary>
/// Abstract class for Trichosomus (genus).
/// NCBI TaxId: 2057077
/// </summary>
public abstract class Trichosomus : Tetrarogidae, ITrichosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2057077;

    /// <inheritdoc />
    public virtual string GenusName => "Trichosomus";

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
