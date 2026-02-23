using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Daector;

/// <summary>
/// Abstract class for Daector (genus).
/// NCBI TaxId: 390317
/// </summary>
public abstract class Daector : Batrachoididae, IDaector
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daector";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390317;

    /// <inheritdoc />
    public virtual string GenusName => "Daector";

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
