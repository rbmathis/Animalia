using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Sundoreonectes;

/// <summary>
/// Abstract class for Sundoreonectes (genus).
/// NCBI TaxId: 3119494
/// </summary>
public abstract class Sundoreonectes : Nemacheilidae, ISundoreonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundoreonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119494;

    /// <inheritdoc />
    public virtual string GenusName => "Sundoreonectes";

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
