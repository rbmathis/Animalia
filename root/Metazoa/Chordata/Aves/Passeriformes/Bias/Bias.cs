using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bias;

/// <summary>
/// Abstract class for Bias (genus).
/// NCBI TaxId: 272805
/// </summary>
public abstract class Bias : Passeriformes, IBias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272805;

    /// <inheritdoc />
    public virtual string GenusName => "Bias";

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
