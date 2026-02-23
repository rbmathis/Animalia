using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Ramphocinclus;

/// <summary>
/// Abstract class for Ramphocinclus (genus).
/// NCBI TaxId: 111994
/// </summary>
public abstract class Ramphocinclus : Mimidae, IRamphocinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphocinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111994;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphocinclus";

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
