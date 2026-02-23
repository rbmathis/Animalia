using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Engystomops;

/// <summary>
/// Abstract class for Engystomops (genus).
/// NCBI TaxId: 365332
/// </summary>
public abstract class Engystomops : Leptodactylidae, IEngystomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Engystomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365332;

    /// <inheritdoc />
    public virtual string GenusName => "Engystomops";

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
