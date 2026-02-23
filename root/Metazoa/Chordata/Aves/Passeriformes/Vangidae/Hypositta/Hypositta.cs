using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Hypositta;

/// <summary>
/// Abstract class for Hypositta (genus).
/// NCBI TaxId: 125304
/// </summary>
public abstract class Hypositta : Vangidae, IHypositta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypositta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125304;

    /// <inheritdoc />
    public virtual string GenusName => "Hypositta";

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
