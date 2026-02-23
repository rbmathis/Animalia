using AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Kinosternon;

/// <summary>
/// Abstract class for Kinosternon (genus).
/// NCBI TaxId: 55538
/// </summary>
public abstract class Kinosternon : Kinosternidae, IKinosternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kinosternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55538;

    /// <inheritdoc />
    public virtual string GenusName => "Kinosternon";

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
