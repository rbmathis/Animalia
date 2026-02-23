using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Bythaelurus;

/// <summary>
/// Abstract class for Bythaelurus (genus).
/// NCBI TaxId: 876122
/// </summary>
public abstract class Bythaelurus : Scyliorhinidae, IBythaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bythaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 876122;

    /// <inheritdoc />
    public virtual string GenusName => "Bythaelurus";

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
