using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Schizoeaca;

/// <summary>
/// Abstract class for Schizoeaca (genus).
/// NCBI TaxId: 329491
/// </summary>
public abstract class Schizoeaca : Furnariidae, ISchizoeaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizoeaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329491;

    /// <inheritdoc />
    public virtual string GenusName => "Schizoeaca";

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
