using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Geositta;

/// <summary>
/// Abstract class for Geositta (genus).
/// NCBI TaxId: 265633
/// </summary>
public abstract class Geositta : Furnariidae, IGeositta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geositta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265633;

    /// <inheritdoc />
    public virtual string GenusName => "Geositta";

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
