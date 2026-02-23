using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Baldwinella;

/// <summary>
/// Abstract class for Baldwinella (genus).
/// NCBI TaxId: 1206926
/// </summary>
public abstract class Baldwinella : Anthiadidae, IBaldwinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baldwinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206926;

    /// <inheritdoc />
    public virtual string GenusName => "Baldwinella";

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
