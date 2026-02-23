using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pterapogon;

/// <summary>
/// Abstract class for Pterapogon (genus).
/// NCBI TaxId: 215348
/// </summary>
public abstract class Pterapogon : Apogonidae, IPterapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215348;

    /// <inheritdoc />
    public virtual string GenusName => "Pterapogon";

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
