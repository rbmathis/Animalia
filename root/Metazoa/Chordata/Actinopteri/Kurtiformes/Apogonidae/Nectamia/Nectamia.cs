using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Nectamia;

/// <summary>
/// Abstract class for Nectamia (genus).
/// NCBI TaxId: 638237
/// </summary>
public abstract class Nectamia : Apogonidae, INectamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nectamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638237;

    /// <inheritdoc />
    public virtual string GenusName => "Nectamia";

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
