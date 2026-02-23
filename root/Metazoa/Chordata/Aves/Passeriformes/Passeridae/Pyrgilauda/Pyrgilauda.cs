using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Pyrgilauda;

/// <summary>
/// Abstract class for Pyrgilauda (genus).
/// NCBI TaxId: 667179
/// </summary>
public abstract class Pyrgilauda : Passeridae, IPyrgilauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrgilauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 667179;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrgilauda";

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
