using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Caiapobrycon;

/// <summary>
/// Abstract class for Caiapobrycon (genus).
/// NCBI TaxId: 2608209
/// </summary>
public abstract class Caiapobrycon : Stevardiidae, ICaiapobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caiapobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608209;

    /// <inheritdoc />
    public virtual string GenusName => "Caiapobrycon";

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
