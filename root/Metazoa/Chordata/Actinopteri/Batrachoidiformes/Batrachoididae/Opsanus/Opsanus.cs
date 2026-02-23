using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Opsanus;

/// <summary>
/// Abstract class for Opsanus (genus).
/// NCBI TaxId: 8067
/// </summary>
public abstract class Opsanus : Batrachoididae, IOpsanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8067;

    /// <inheritdoc />
    public virtual string GenusName => "Opsanus";

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
