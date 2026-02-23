using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelops;

/// <summary>
/// Abstract class for Camelops (genus).
/// NCBI TaxId: 647690
/// </summary>
public abstract class Camelops : Camelidae, ICamelops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camelops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 647690;

    /// <inheritdoc />
    public virtual string GenusName => "Camelops";

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
