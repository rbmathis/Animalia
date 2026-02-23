using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Systellura;

/// <summary>
/// Abstract class for Systellura (genus).
/// NCBI TaxId: 1977149
/// </summary>
public abstract class Systellura : Caprimulgidae, ISystellura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Systellura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1977149;

    /// <inheritdoc />
    public virtual string GenusName => "Systellura";

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
