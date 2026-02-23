using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Yuhina;

/// <summary>
/// Abstract class for Yuhina (genus).
/// NCBI TaxId: 98155
/// </summary>
public abstract class Yuhina : Timaliidae, IYuhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yuhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98155;

    /// <inheritdoc />
    public virtual string GenusName => "Yuhina";

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
