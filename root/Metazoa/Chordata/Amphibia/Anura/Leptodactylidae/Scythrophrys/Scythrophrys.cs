using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Scythrophrys;

/// <summary>
/// Abstract class for Scythrophrys (genus).
/// NCBI TaxId: 356327
/// </summary>
public abstract class Scythrophrys : Leptodactylidae, IScythrophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scythrophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356327;

    /// <inheritdoc />
    public virtual string GenusName => "Scythrophrys";

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
