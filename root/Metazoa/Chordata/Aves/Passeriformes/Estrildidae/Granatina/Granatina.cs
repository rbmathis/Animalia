using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Granatina;

/// <summary>
/// Abstract class for Granatina (genus).
/// NCBI TaxId: 2715641
/// </summary>
public abstract class Granatina : Estrildidae, IGranatina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Granatina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715641;

    /// <inheritdoc />
    public virtual string GenusName => "Granatina";

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
