using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Sturnella;

/// <summary>
/// Abstract class for Sturnella (genus).
/// NCBI TaxId: 56328
/// </summary>
public abstract class Sturnella : Icteridae, ISturnella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sturnella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56328;

    /// <inheritdoc />
    public virtual string GenusName => "Sturnella";

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
