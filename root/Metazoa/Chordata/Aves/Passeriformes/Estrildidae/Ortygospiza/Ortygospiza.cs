using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Ortygospiza;

/// <summary>
/// Abstract class for Ortygospiza (genus).
/// NCBI TaxId: 187438
/// </summary>
public abstract class Ortygospiza : Estrildidae, IOrtygospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ortygospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187438;

    /// <inheritdoc />
    public virtual string GenusName => "Ortygospiza";

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
