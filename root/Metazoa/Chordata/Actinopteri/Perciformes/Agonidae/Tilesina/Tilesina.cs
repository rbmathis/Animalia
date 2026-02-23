using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Tilesina;

/// <summary>
/// Abstract class for Tilesina (genus).
/// NCBI TaxId: 255543
/// </summary>
public abstract class Tilesina : Agonidae, ITilesina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tilesina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255543;

    /// <inheritdoc />
    public virtual string GenusName => "Tilesina";

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
