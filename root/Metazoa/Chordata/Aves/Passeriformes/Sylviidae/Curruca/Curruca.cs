using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Curruca;

/// <summary>
/// Abstract class for Curruca (genus).
/// NCBI TaxId: 1930205
/// </summary>
public abstract class Curruca : Sylviidae, ICurruca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Curruca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1930205;

    /// <inheritdoc />
    public virtual string GenusName => "Curruca";

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
