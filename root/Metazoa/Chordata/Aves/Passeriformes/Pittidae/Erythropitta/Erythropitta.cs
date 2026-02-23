using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Erythropitta;

/// <summary>
/// Abstract class for Erythropitta (genus).
/// NCBI TaxId: 1316415
/// </summary>
public abstract class Erythropitta : Pittidae, IErythropitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythropitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1316415;

    /// <inheritdoc />
    public virtual string GenusName => "Erythropitta";

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
