using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Anthoscopus;

/// <summary>
/// Abstract class for Anthoscopus (genus).
/// NCBI TaxId: 156560
/// </summary>
public abstract class Anthoscopus : Paridae, IAnthoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156560;

    /// <inheritdoc />
    public virtual string GenusName => "Anthoscopus";

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
