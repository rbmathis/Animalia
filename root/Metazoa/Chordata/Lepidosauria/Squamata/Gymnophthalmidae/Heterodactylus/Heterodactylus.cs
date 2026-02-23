using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Heterodactylus;

/// <summary>
/// Abstract class for Heterodactylus (genus).
/// NCBI TaxId: 174749
/// </summary>
public abstract class Heterodactylus : Gymnophthalmidae, IHeterodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174749;

    /// <inheritdoc />
    public virtual string GenusName => "Heterodactylus";

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
