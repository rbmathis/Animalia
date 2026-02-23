using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae.Graus;

/// <summary>
/// Abstract class for Graus (genus).
/// NCBI TaxId: 326167
/// </summary>
public abstract class Graus : Girellidae, IGraus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326167;

    /// <inheritdoc />
    public virtual string GenusName => "Graus";

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
