using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cercamia;

/// <summary>
/// Abstract class for Cercamia (genus).
/// NCBI TaxId: 638233
/// </summary>
public abstract class Cercamia : Apogonidae, ICercamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638233;

    /// <inheritdoc />
    public virtual string GenusName => "Cercamia";

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
