using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Aerodramus;

/// <summary>
/// Abstract class for Aerodramus (genus).
/// NCBI TaxId: 46474
/// </summary>
public abstract class Aerodramus : Apodidae, IAerodramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aerodramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46474;

    /// <inheritdoc />
    public virtual string GenusName => "Aerodramus";

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
