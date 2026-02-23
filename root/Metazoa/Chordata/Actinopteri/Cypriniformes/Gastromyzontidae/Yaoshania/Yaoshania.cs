using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Yaoshania;

/// <summary>
/// Abstract class for Yaoshania (genus).
/// NCBI TaxId: 1772094
/// </summary>
public abstract class Yaoshania : Gastromyzontidae, IYaoshania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yaoshania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772094;

    /// <inheritdoc />
    public virtual string GenusName => "Yaoshania";

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
