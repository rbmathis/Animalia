using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Pyrenestes;

/// <summary>
/// Abstract class for Pyrenestes (genus).
/// NCBI TaxId: 247711
/// </summary>
public abstract class Pyrenestes : Estrildidae, IPyrenestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrenestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247711;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrenestes";

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
