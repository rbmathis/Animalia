using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Himatione;

/// <summary>
/// Abstract class for Himatione (genus).
/// NCBI TaxId: 64800
/// </summary>
public abstract class Himatione : Fringillidae, IHimatione
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Himatione";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64800;

    /// <inheritdoc />
    public virtual string GenusName => "Himatione";

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
