using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Laemonema;

/// <summary>
/// Abstract class for Laemonema (genus).
/// NCBI TaxId: 228652
/// </summary>
public abstract class Laemonema : Moridae, ILaemonema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laemonema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228652;

    /// <inheritdoc />
    public virtual string GenusName => "Laemonema";

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
