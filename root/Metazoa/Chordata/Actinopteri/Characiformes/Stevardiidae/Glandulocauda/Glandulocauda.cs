using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Glandulocauda;

/// <summary>
/// Abstract class for Glandulocauda (genus).
/// NCBI TaxId: 930323
/// </summary>
public abstract class Glandulocauda : Stevardiidae, IGlandulocauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glandulocauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930323;

    /// <inheritdoc />
    public virtual string GenusName => "Glandulocauda";

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
