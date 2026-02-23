using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrachoides;

/// <summary>
/// Abstract class for Batrachoides (genus).
/// NCBI TaxId: 747528
/// </summary>
public abstract class Batrachoides : Batrachoididae, IBatrachoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 747528;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachoides";

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
