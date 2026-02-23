using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Thripadectes;

/// <summary>
/// Abstract class for Thripadectes (genus).
/// NCBI TaxId: 183162
/// </summary>
public abstract class Thripadectes : Furnariidae, IThripadectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thripadectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183162;

    /// <inheritdoc />
    public virtual string GenusName => "Thripadectes";

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
