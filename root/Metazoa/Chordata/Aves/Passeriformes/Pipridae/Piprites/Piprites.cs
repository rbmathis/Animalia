using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Piprites;

/// <summary>
/// Abstract class for Piprites (genus).
/// NCBI TaxId: 114368
/// </summary>
public abstract class Piprites : Pipridae, IPiprites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piprites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114368;

    /// <inheritdoc />
    public virtual string GenusName => "Piprites";

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
