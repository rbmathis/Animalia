using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Galeus;

/// <summary>
/// Abstract class for Galeus (genus).
/// NCBI TaxId: 77913
/// </summary>
public abstract class Galeus : Scyliorhinidae, IGaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77913;

    /// <inheritdoc />
    public virtual string GenusName => "Galeus";

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
