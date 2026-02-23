using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lygodactylus;

/// <summary>
/// Abstract class for Lygodactylus (genus).
/// NCBI TaxId: 57063
/// </summary>
public abstract class Lygodactylus : Gekkonidae, ILygodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lygodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57063;

    /// <inheritdoc />
    public virtual string GenusName => "Lygodactylus";

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
