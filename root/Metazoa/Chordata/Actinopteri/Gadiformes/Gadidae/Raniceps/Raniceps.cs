using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Raniceps;

/// <summary>
/// Abstract class for Raniceps (genus).
/// NCBI TaxId: 163116
/// </summary>
public abstract class Raniceps : Gadidae, IRaniceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raniceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163116;

    /// <inheritdoc />
    public virtual string GenusName => "Raniceps";

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
