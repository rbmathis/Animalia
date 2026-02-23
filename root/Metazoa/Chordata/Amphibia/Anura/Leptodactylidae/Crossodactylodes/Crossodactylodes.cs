using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Crossodactylodes;

/// <summary>
/// Abstract class for Crossodactylodes (genus).
/// NCBI TaxId: 613076
/// </summary>
public abstract class Crossodactylodes : Leptodactylidae, ICrossodactylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossodactylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613076;

    /// <inheritdoc />
    public virtual string GenusName => "Crossodactylodes";

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
