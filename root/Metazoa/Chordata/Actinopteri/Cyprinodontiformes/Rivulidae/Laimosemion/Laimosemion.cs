using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Laimosemion;

/// <summary>
/// Abstract class for Laimosemion (genus).
/// NCBI TaxId: 1254424
/// </summary>
public abstract class Laimosemion : Rivulidae, ILaimosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laimosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1254424;

    /// <inheritdoc />
    public virtual string GenusName => "Laimosemion";

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
