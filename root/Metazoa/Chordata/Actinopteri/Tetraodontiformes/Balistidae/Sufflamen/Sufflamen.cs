using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Sufflamen;

/// <summary>
/// Abstract class for Sufflamen (genus).
/// NCBI TaxId: 181477
/// </summary>
public abstract class Sufflamen : Balistidae, ISufflamen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sufflamen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181477;

    /// <inheritdoc />
    public virtual string GenusName => "Sufflamen";

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
