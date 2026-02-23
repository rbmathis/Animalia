using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Abstract class for Megapodius (genus).
/// NCBI TaxId: 8978
/// </summary>
public abstract class Megapodius : Megapodiidae, IMegapodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megapodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8978;

    /// <inheritdoc />
    public virtual string GenusName => "Megapodius";

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
