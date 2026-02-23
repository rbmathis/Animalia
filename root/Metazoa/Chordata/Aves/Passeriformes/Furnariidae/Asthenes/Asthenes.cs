using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Asthenes;

/// <summary>
/// Abstract class for Asthenes (genus).
/// NCBI TaxId: 9137
/// </summary>
public abstract class Asthenes : Furnariidae, IAsthenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asthenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9137;

    /// <inheritdoc />
    public virtual string GenusName => "Asthenes";

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
