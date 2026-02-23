using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttiella;

/// <summary>
/// Abstract class for Harttiella (genus).
/// NCBI TaxId: 1137728
/// </summary>
public abstract class Harttiella : Loricariidae, IHarttiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harttiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1137728;

    /// <inheritdoc />
    public virtual string GenusName => "Harttiella";

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
