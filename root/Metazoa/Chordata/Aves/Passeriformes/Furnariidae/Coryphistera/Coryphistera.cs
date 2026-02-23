using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Coryphistera;

/// <summary>
/// Abstract class for Coryphistera (genus).
/// NCBI TaxId: 183172
/// </summary>
public abstract class Coryphistera : Furnariidae, ICoryphistera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphistera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183172;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphistera";

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
