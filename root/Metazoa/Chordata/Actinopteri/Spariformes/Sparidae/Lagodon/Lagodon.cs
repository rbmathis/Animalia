using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Lagodon;

/// <summary>
/// Abstract class for Lagodon (genus).
/// NCBI TaxId: 50350
/// </summary>
public abstract class Lagodon : Sparidae, ILagodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50350;

    /// <inheritdoc />
    public virtual string GenusName => "Lagodon";

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
