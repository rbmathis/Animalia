using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Ephippus;

/// <summary>
/// Abstract class for Ephippus (genus).
/// NCBI TaxId: 455452
/// </summary>
public abstract class Ephippus : Ephippidae, IEphippus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ephippus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 455452;

    /// <inheritdoc />
    public virtual string GenusName => "Ephippus";

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
