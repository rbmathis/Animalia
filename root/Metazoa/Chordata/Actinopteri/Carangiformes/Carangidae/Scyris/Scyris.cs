using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Scyris;

/// <summary>
/// Abstract class for Scyris (genus).
/// NCBI TaxId: 3040448
/// </summary>
public abstract class Scyris : Carangidae, IScyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040448;

    /// <inheritdoc />
    public virtual string GenusName => "Scyris";

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
