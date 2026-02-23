using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Halaelurus;

/// <summary>
/// Abstract class for Halaelurus (genus).
/// NCBI TaxId: 88061
/// </summary>
public abstract class Halaelurus : Scyliorhinidae, IHalaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88061;

    /// <inheritdoc />
    public virtual string GenusName => "Halaelurus";

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
