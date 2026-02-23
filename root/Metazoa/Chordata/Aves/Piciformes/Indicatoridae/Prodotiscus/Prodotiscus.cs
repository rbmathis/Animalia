using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Prodotiscus;

/// <summary>
/// Abstract class for Prodotiscus (genus).
/// NCBI TaxId: 1002874
/// </summary>
public abstract class Prodotiscus : Indicatoridae, IProdotiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prodotiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002874;

    /// <inheritdoc />
    public virtual string GenusName => "Prodotiscus";

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
