using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Speonectes;

/// <summary>
/// Abstract class for Speonectes (genus).
/// NCBI TaxId: 3119492
/// </summary>
public abstract class Speonectes : Nemacheilidae, ISpeonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119492;

    /// <inheritdoc />
    public virtual string GenusName => "Speonectes";

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
