using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Hucho;

/// <summary>
/// Abstract class for Hucho (genus).
/// NCBI TaxId: 8041
/// </summary>
public abstract class Hucho : Salmonidae, IHucho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hucho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8041;

    /// <inheritdoc />
    public virtual string GenusName => "Hucho";

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
