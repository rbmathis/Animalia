using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovibos;

/// <summary>
/// Abstract class for Ovibos (genus).
/// NCBI TaxId: 37175
/// </summary>
public abstract class Ovibos : Bovidae, IOvibos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ovibos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37175;

    /// <inheritdoc />
    public virtual string GenusName => "Ovibos";

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
