using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Heteromunia;

/// <summary>
/// Abstract class for Heteromunia (genus).
/// NCBI TaxId: 247809
/// </summary>
public abstract class Heteromunia : Estrildidae, IHeteromunia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromunia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247809;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromunia";

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
