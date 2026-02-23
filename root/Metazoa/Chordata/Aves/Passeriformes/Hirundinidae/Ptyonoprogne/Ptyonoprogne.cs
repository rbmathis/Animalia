using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Ptyonoprogne;

/// <summary>
/// Abstract class for Ptyonoprogne (genus).
/// NCBI TaxId: 72889
/// </summary>
public abstract class Ptyonoprogne : Hirundinidae, IPtyonoprogne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptyonoprogne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72889;

    /// <inheritdoc />
    public virtual string GenusName => "Ptyonoprogne";

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
