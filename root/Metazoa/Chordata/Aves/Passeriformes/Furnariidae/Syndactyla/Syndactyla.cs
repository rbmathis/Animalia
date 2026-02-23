using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Syndactyla;

/// <summary>
/// Abstract class for Syndactyla (genus).
/// NCBI TaxId: 329511
/// </summary>
public abstract class Syndactyla : Furnariidae, ISyndactyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syndactyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329511;

    /// <inheritdoc />
    public virtual string GenusName => "Syndactyla";

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
