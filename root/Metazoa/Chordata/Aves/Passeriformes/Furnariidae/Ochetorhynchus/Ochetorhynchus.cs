using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Ochetorhynchus;

/// <summary>
/// Abstract class for Ochetorhynchus (genus).
/// NCBI TaxId: 2823047
/// </summary>
public abstract class Ochetorhynchus : Furnariidae, IOchetorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochetorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823047;

    /// <inheritdoc />
    public virtual string GenusName => "Ochetorhynchus";

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
