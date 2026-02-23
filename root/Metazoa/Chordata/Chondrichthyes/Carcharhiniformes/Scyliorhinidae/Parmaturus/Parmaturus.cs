using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Parmaturus;

/// <summary>
/// Abstract class for Parmaturus (genus).
/// NCBI TaxId: 263712
/// </summary>
public abstract class Parmaturus : Scyliorhinidae, IParmaturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parmaturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263712;

    /// <inheritdoc />
    public virtual string GenusName => "Parmaturus";

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
