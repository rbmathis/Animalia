using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Nigrita;

/// <summary>
/// Abstract class for Nigrita (genus).
/// NCBI TaxId: 208077
/// </summary>
public abstract class Nigrita : Estrildidae, INigrita
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nigrita";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208077;

    /// <inheritdoc />
    public virtual string GenusName => "Nigrita";

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
