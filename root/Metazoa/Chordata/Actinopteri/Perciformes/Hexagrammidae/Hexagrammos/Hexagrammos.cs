using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Hexagrammos;

/// <summary>
/// Abstract class for Hexagrammos (genus).
/// NCBI TaxId: 72449
/// </summary>
public abstract class Hexagrammos : Hexagrammidae, IHexagrammos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hexagrammos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72449;

    /// <inheritdoc />
    public virtual string GenusName => "Hexagrammos";

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
