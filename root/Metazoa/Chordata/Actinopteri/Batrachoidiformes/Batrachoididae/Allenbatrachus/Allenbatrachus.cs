using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Allenbatrachus;

/// <summary>
/// Abstract class for Allenbatrachus (genus).
/// NCBI TaxId: 101188
/// </summary>
public abstract class Allenbatrachus : Batrachoididae, IAllenbatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allenbatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101188;

    /// <inheritdoc />
    public virtual string GenusName => "Allenbatrachus";

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
