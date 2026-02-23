using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Geoffroyus;

/// <summary>
/// Abstract class for Geoffroyus (genus).
/// NCBI TaxId: 503986
/// </summary>
public abstract class Geoffroyus : Psittacidae, IGeoffroyus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geoffroyus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503986;

    /// <inheritdoc />
    public virtual string GenusName => "Geoffroyus";

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
