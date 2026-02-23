using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Megalurus;

/// <summary>
/// Abstract class for Megalurus (genus).
/// NCBI TaxId: 69941
/// </summary>
public abstract class Megalurus : Locustellidae, IMegalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69941;

    /// <inheritdoc />
    public virtual string GenusName => "Megalurus";

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
