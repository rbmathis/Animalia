using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Ictonyx;

/// <summary>
/// Abstract class for Ictonyx (genus).
/// NCBI TaxId: 55049
/// </summary>
public abstract class Ictonyx : Mustelidae, IIctonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55049;

    /// <inheritdoc />
    public virtual string GenusName => "Ictonyx";

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
