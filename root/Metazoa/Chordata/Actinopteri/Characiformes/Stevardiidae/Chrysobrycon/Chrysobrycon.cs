using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Chrysobrycon;

/// <summary>
/// Abstract class for Chrysobrycon (genus).
/// NCBI TaxId: 1463120
/// </summary>
public abstract class Chrysobrycon : Stevardiidae, IChrysobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463120;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysobrycon";

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
