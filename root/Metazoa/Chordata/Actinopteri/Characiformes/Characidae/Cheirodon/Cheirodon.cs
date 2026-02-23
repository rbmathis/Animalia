using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cheirodon;

/// <summary>
/// Abstract class for Cheirodon (genus).
/// NCBI TaxId: 42601
/// </summary>
public abstract class Cheirodon : Characidae, ICheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42601;

    /// <inheritdoc />
    public virtual string GenusName => "Cheirodon";

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
