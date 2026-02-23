using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Nannopetersius;

/// <summary>
/// Abstract class for Nannopetersius (genus).
/// NCBI TaxId: 206425
/// </summary>
public abstract class Nannopetersius : Alestidae, INannopetersius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannopetersius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206425;

    /// <inheritdoc />
    public virtual string GenusName => "Nannopetersius";

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
