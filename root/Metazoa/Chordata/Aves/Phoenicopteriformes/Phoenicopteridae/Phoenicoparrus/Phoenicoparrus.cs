using AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoenicoparrus;

/// <summary>
/// Abstract class for Phoenicoparrus (genus).
/// NCBI TaxId: 704176
/// </summary>
public abstract class Phoenicoparrus : Phoenicopteridae, IPhoenicoparrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoenicoparrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 704176;

    /// <inheritdoc />
    public virtual string GenusName => "Phoenicoparrus";

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
