using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Chrysomma;

/// <summary>
/// Abstract class for Chrysomma (genus).
/// NCBI TaxId: 201303
/// </summary>
public abstract class Chrysomma : Timaliidae, IChrysomma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysomma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201303;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysomma";

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
