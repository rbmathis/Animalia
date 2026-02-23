using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Chaetostoma;

/// <summary>
/// Abstract class for Chaetostoma (genus).
/// NCBI TaxId: 52077
/// </summary>
public abstract class Chaetostoma : Loricariidae, IChaetostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52077;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetostoma";

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
