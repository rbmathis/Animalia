using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Riparia;

/// <summary>
/// Abstract class for Riparia (genus).
/// NCBI TaxId: 72879
/// </summary>
public abstract class Riparia : Hirundinidae, IRiparia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Riparia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72879;

    /// <inheritdoc />
    public virtual string GenusName => "Riparia";

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
