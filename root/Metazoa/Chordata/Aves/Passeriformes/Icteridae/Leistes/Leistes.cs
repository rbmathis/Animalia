using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Leistes;

/// <summary>
/// Abstract class for Leistes (genus).
/// NCBI TaxId: 84808
/// </summary>
public abstract class Leistes : Icteridae, ILeistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84808;

    /// <inheritdoc />
    public virtual string GenusName => "Leistes";

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
