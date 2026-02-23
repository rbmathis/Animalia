using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

/// <summary>
/// Abstract class for Camelus (genus).
/// NCBI TaxId: 9836
/// </summary>
public abstract class Camelus : Camelidae, ICamelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9836;

    /// <inheritdoc />
    public virtual string GenusName => "Camelus";

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
