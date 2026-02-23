using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Thalassophryne;

/// <summary>
/// Abstract class for Thalassophryne (genus).
/// NCBI TaxId: 289381
/// </summary>
public abstract class Thalassophryne : Batrachoididae, IThalassophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 289381;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassophryne";

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
