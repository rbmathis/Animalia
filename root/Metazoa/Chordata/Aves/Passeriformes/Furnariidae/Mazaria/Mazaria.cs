using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Mazaria;

/// <summary>
/// Abstract class for Mazaria (genus).
/// NCBI TaxId: 2767937
/// </summary>
public abstract class Mazaria : Furnariidae, IMazaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mazaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767937;

    /// <inheritdoc />
    public virtual string GenusName => "Mazaria";

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
