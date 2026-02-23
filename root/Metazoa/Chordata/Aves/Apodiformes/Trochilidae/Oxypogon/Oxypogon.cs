using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Oxypogon;

/// <summary>
/// Abstract class for Oxypogon (genus).
/// NCBI TaxId: 472898
/// </summary>
public abstract class Oxypogon : Trochilidae, IOxypogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxypogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472898;

    /// <inheritdoc />
    public virtual string GenusName => "Oxypogon";

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
