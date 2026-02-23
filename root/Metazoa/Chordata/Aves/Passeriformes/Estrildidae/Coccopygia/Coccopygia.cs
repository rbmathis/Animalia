using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Coccopygia;

/// <summary>
/// Abstract class for Coccopygia (genus).
/// NCBI TaxId: 2821306
/// </summary>
public abstract class Coccopygia : Estrildidae, ICoccopygia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coccopygia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821306;

    /// <inheritdoc />
    public virtual string GenusName => "Coccopygia";

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
