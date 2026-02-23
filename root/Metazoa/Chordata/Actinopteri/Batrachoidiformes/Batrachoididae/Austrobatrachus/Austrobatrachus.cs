using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Austrobatrachus;

/// <summary>
/// Abstract class for Austrobatrachus (genus).
/// NCBI TaxId: 990941
/// </summary>
public abstract class Austrobatrachus : Batrachoididae, IAustrobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990941;

    /// <inheritdoc />
    public virtual string GenusName => "Austrobatrachus";

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
