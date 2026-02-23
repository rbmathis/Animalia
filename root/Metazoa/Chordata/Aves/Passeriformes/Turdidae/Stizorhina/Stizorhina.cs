using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Stizorhina;

/// <summary>
/// Abstract class for Stizorhina (genus).
/// NCBI TaxId: 127942
/// </summary>
public abstract class Stizorhina : Turdidae, IStizorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stizorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127942;

    /// <inheritdoc />
    public virtual string GenusName => "Stizorhina";

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
