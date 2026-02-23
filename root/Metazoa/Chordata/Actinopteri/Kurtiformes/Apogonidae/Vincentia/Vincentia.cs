using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Vincentia;

/// <summary>
/// Abstract class for Vincentia (genus).
/// NCBI TaxId: 1431513
/// </summary>
public abstract class Vincentia : Apogonidae, IVincentia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vincentia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1431513;

    /// <inheritdoc />
    public virtual string GenusName => "Vincentia";

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
