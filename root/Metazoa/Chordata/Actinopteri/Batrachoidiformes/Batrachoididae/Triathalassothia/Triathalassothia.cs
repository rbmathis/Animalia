using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Triathalassothia;

/// <summary>
/// Abstract class for Triathalassothia (genus).
/// NCBI TaxId: 990955
/// </summary>
public abstract class Triathalassothia : Batrachoididae, ITriathalassothia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triathalassothia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990955;

    /// <inheritdoc />
    public virtual string GenusName => "Triathalassothia";

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
