using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Dactylocnemis;

/// <summary>
/// Abstract class for Dactylocnemis (genus).
/// NCBI TaxId: 1413805
/// </summary>
public abstract class Dactylocnemis : Diplodactylidae, IDactylocnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylocnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1413805;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylocnemis";

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
