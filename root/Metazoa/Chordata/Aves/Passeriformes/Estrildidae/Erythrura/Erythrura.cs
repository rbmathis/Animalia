using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Erythrura;

/// <summary>
/// Abstract class for Erythrura (genus).
/// NCBI TaxId: 44315
/// </summary>
public abstract class Erythrura : Estrildidae, IErythrura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44315;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrura";

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
