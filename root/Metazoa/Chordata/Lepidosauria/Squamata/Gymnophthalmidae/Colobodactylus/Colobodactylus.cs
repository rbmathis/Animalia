using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Colobodactylus;

/// <summary>
/// Abstract class for Colobodactylus (genus).
/// NCBI TaxId: 174743
/// </summary>
public abstract class Colobodactylus : Gymnophthalmidae, IColobodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colobodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174743;

    /// <inheritdoc />
    public virtual string GenusName => "Colobodactylus";

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
