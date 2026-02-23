using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Tyranneutes;

/// <summary>
/// Abstract class for Tyranneutes (genus).
/// NCBI TaxId: 265629
/// </summary>
public abstract class Tyranneutes : Pipridae, ITyranneutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyranneutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265629;

    /// <inheritdoc />
    public virtual string GenusName => "Tyranneutes";

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
