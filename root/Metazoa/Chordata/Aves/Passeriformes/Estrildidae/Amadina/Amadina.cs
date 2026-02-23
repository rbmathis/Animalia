using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Amadina;

/// <summary>
/// Abstract class for Amadina (genus).
/// NCBI TaxId: 247726
/// </summary>
public abstract class Amadina : Estrildidae, IAmadina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amadina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247726;

    /// <inheritdoc />
    public virtual string GenusName => "Amadina";

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
