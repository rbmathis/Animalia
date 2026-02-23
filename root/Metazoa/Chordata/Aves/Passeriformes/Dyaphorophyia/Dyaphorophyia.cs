using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dyaphorophyia;

/// <summary>
/// Abstract class for Dyaphorophyia (genus).
/// NCBI TaxId: 1160850
/// </summary>
public abstract class Dyaphorophyia : Passeriformes, IDyaphorophyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dyaphorophyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1160850;

    /// <inheritdoc />
    public virtual string GenusName => "Dyaphorophyia";

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
