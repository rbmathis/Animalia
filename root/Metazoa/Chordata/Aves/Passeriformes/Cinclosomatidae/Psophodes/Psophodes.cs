using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Psophodes;

/// <summary>
/// Abstract class for Psophodes (genus).
/// NCBI TaxId: 461241
/// </summary>
public abstract class Psophodes : Cinclosomatidae, IPsophodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psophodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461241;

    /// <inheritdoc />
    public virtual string GenusName => "Psophodes";

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
