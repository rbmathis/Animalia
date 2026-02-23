using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Semnodactylus;

/// <summary>
/// Abstract class for Semnodactylus (genus).
/// NCBI TaxId: 143465
/// </summary>
public abstract class Semnodactylus : Hyperoliidae, ISemnodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semnodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143465;

    /// <inheritdoc />
    public virtual string GenusName => "Semnodactylus";

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
