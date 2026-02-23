using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Rosenblattia;

/// <summary>
/// Abstract class for Rosenblattia (genus).
/// NCBI TaxId: 1867360
/// </summary>
public abstract class Rosenblattia : Epigonidae, IRosenblattia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rosenblattia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1867360;

    /// <inheritdoc />
    public virtual string GenusName => "Rosenblattia";

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
