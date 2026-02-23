using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Malimbus;

/// <summary>
/// Abstract class for Malimbus (genus).
/// NCBI TaxId: 570452
/// </summary>
public abstract class Malimbus : Ploceidae, IMalimbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malimbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570452;

    /// <inheritdoc />
    public virtual string GenusName => "Malimbus";

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
