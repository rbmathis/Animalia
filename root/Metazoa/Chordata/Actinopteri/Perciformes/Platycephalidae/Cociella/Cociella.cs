using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Cociella;

/// <summary>
/// Abstract class for Cociella (genus).
/// NCBI TaxId: 497286
/// </summary>
public abstract class Cociella : Platycephalidae, ICociella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cociella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497286;

    /// <inheritdoc />
    public virtual string GenusName => "Cociella";

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
