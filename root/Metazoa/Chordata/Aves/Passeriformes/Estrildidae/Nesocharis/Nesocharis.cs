using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Nesocharis;

/// <summary>
/// Abstract class for Nesocharis (genus).
/// NCBI TaxId: 247724
/// </summary>
public abstract class Nesocharis : Estrildidae, INesocharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesocharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247724;

    /// <inheritdoc />
    public virtual string GenusName => "Nesocharis";

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
