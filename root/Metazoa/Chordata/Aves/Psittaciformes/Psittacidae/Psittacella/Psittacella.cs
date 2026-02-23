using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacella;

/// <summary>
/// Abstract class for Psittacella (genus).
/// NCBI TaxId: 458122
/// </summary>
public abstract class Psittacella : Psittacidae, IPsittacella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittacella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458122;

    /// <inheritdoc />
    public virtual string GenusName => "Psittacella";

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
