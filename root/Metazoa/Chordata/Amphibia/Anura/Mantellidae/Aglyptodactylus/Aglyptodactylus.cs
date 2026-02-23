using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Aglyptodactylus;

/// <summary>
/// Abstract class for Aglyptodactylus (genus).
/// NCBI TaxId: 68423
/// </summary>
public abstract class Aglyptodactylus : Mantellidae, IAglyptodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aglyptodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68423;

    /// <inheritdoc />
    public virtual string GenusName => "Aglyptodactylus";

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
