using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Epigonus;

/// <summary>
/// Abstract class for Epigonus (genus).
/// NCBI TaxId: 270551
/// </summary>
public abstract class Epigonus : Epigonidae, IEpigonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epigonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270551;

    /// <inheritdoc />
    public virtual string GenusName => "Epigonus";

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
