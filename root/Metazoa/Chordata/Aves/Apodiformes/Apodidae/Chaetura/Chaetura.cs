using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Chaetura;

/// <summary>
/// Abstract class for Chaetura (genus).
/// NCBI TaxId: 8896
/// </summary>
public abstract class Chaetura : Apodidae, IChaetura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8896;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetura";

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
