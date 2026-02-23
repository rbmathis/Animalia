using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pipra;

/// <summary>
/// Abstract class for Pipra (genus).
/// NCBI TaxId: 88178
/// </summary>
public abstract class Pipra : Pipridae, IPipra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88178;

    /// <inheritdoc />
    public virtual string GenusName => "Pipra";

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
