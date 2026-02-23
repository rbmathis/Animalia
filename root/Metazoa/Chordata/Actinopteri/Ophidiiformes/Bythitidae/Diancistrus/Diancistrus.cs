using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Diancistrus;

/// <summary>
/// Abstract class for Diancistrus (genus).
/// NCBI TaxId: 1312404
/// </summary>
public abstract class Diancistrus : Bythitidae, IDiancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312404;

    /// <inheritdoc />
    public virtual string GenusName => "Diancistrus";

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
