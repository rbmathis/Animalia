using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Elminia;

/// <summary>
/// Abstract class for Elminia (genus).
/// NCBI TaxId: 81908
/// </summary>
public abstract class Elminia : Stenostiridae, IElminia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elminia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81908;

    /// <inheritdoc />
    public virtual string GenusName => "Elminia";

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
