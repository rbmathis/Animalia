using AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Platysternidae.Platysternon;

/// <summary>
/// Abstract class for Platysternon (genus).
/// NCBI TaxId: 55543
/// </summary>
public abstract class Platysternon : Platysternidae, IPlatysternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platysternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55543;

    /// <inheritdoc />
    public virtual string GenusName => "Platysternon";

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
