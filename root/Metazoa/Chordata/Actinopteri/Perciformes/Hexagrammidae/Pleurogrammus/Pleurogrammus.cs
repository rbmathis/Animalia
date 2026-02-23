using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Pleurogrammus;

/// <summary>
/// Abstract class for Pleurogrammus (genus).
/// NCBI TaxId: 175281
/// </summary>
public abstract class Pleurogrammus : Hexagrammidae, IPleurogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleurogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175281;

    /// <inheritdoc />
    public virtual string GenusName => "Pleurogrammus";

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
