using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Hypergerus;

/// <summary>
/// Abstract class for Hypergerus (genus).
/// NCBI TaxId: 98128
/// </summary>
public abstract class Hypergerus : Cisticolidae, IHypergerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypergerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98128;

    /// <inheritdoc />
    public virtual string GenusName => "Hypergerus";

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
