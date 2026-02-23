using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Arachnothera;

/// <summary>
/// Abstract class for Arachnothera (genus).
/// NCBI TaxId: 237414
/// </summary>
public abstract class Arachnothera : Nectariniidae, IArachnothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arachnothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237414;

    /// <inheritdoc />
    public virtual string GenusName => "Arachnothera";

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
