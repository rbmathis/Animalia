using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Parapsettus;

/// <summary>
/// Abstract class for Parapsettus (genus).
/// NCBI TaxId: 2986110
/// </summary>
public abstract class Parapsettus : Ephippidae, IParapsettus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapsettus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986110;

    /// <inheritdoc />
    public virtual string GenusName => "Parapsettus";

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
