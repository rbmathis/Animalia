using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Rhamdiopsis;

/// <summary>
/// Abstract class for Rhamdiopsis (genus).
/// NCBI TaxId: 1123876
/// </summary>
public abstract class Rhamdiopsis : Heptapteridae, IRhamdiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamdiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1123876;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamdiopsis";

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
