using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Conirostrum;

/// <summary>
/// Abstract class for Conirostrum (genus).
/// NCBI TaxId: 182922
/// </summary>
public abstract class Conirostrum : Thraupidae, IConirostrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conirostrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182922;

    /// <inheritdoc />
    public virtual string GenusName => "Conirostrum";

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
