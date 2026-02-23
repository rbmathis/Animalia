using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lampiella;

/// <summary>
/// Abstract class for Lampiella (genus).
/// NCBI TaxId: 745513
/// </summary>
public abstract class Lampiella : Loricariidae, ILampiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745513;

    /// <inheritdoc />
    public virtual string GenusName => "Lampiella";

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
