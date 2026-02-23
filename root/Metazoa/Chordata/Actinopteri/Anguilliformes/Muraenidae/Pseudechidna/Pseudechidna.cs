using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Pseudechidna;

/// <summary>
/// Abstract class for Pseudechidna (genus).
/// NCBI TaxId: 1159275
/// </summary>
public abstract class Pseudechidna : Muraenidae, IPseudechidna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudechidna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1159275;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudechidna";

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
