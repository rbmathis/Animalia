using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Clytospiza;

/// <summary>
/// Abstract class for Clytospiza (genus).
/// NCBI TaxId: 247525
/// </summary>
public abstract class Clytospiza : Estrildidae, IClytospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clytospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247525;

    /// <inheritdoc />
    public virtual string GenusName => "Clytospiza";

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
