using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Barchatus;

/// <summary>
/// Abstract class for Barchatus (genus).
/// NCBI TaxId: 990942
/// </summary>
public abstract class Barchatus : Batrachoididae, IBarchatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barchatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990942;

    /// <inheritdoc />
    public virtual string GenusName => "Barchatus";

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
